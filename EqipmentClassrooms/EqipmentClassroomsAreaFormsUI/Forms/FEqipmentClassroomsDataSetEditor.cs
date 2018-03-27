using Common.Forms.Editing;
using CountriesArea.Data;
using CountriesArea.Domain;
using CountriesArea.FileIO.Interfaces;
using System;
using System.IO;
using System.Windows.Forms;

namespace CountriesAreaFormsUI.Forms
{
    public partial class FCountriesAreaDataSetEditor : Form
    {

        const string countryCaption = "Країни та території";
        const string geographicalRegionCaption =
            "Макрогеографічні та географічні регіони";
        const string populationCaption = "Чисельність населення країн";

        public ICountriesAreaFileIoController FileIoController { get; set; }
        public string FileName { get; set; }

        private FBindingListEditor<Country> _fCountriesEditor;
        private FBindingListEditor<GeographicalRegion> _fGeographicalRegionsEditor;
        private FBindingListEditor<Population> _fPopulationsEditor;

        private string _selectedEntityCaption = null;
        private object _selectedObject = null;

        protected CountriesAreaDataSet _dataSet;

        public FCountriesAreaDataSetEditor(CountriesAreaDataSet dataSet)
        {
            _dataSet = dataSet;

            InitializeComponent();

            Text = "Редактор даних ПО \"Країни\"";
            SetToolStripButtonsImages();

            FillEntitiesList();

            CreateEntitiesEditors();
        }

        private void SetToolStripButtonsImages()
        {
            toolStripEditing.ImageList = imageListEditing;
            toolStripButtonAdd.ImageKey = "add";
            toolStripButtonEdit.ImageKey = "edit";
            toolStripButtonDelete.ImageKey = "delete";
        }

        private void FillEntitiesList()
        {
            listBoxEntities.Items.Add(countryCaption);
            listBoxEntities.Items.Add(geographicalRegionCaption);
            listBoxEntities.Items.Add(populationCaption);
            listBoxEntities.SelectedIndex = 0;
        }

        private void menuDataLoadTestData_Click(object sender, EventArgs e)
        {
            _dataSet.CreateTestData();
            UpdateState();
        }

        private void UpdateState()
        {
            UpdateObjectsList();
        }

        private void UpdateObjectsList()
        {
            listBoxEntityObjects.Items.Clear();
            _selectedEntityCaption = listBoxEntities.SelectedItem.ToString();
            switch (_selectedEntityCaption)
            {
                case countryCaption:
                    foreach (var obj in _dataSet.Countries)
                    {
                        listBoxEntityObjects.Items.Add(obj.Key);
                    }
                    break;
                case geographicalRegionCaption:
                    foreach (var obj in _dataSet.GeographicalRegions)
                    {
                        listBoxEntityObjects.Items.Add(obj.Key);
                    }
                    break;
                case populationCaption:
                    foreach (var obj in _dataSet.Populations)
                    {
                        listBoxEntityObjects.Items.Add(obj.Key);
                    }
                    break;
            }
            ShowEntityData();
        }

        private void listBoxEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateState();
        }

        private void ShowEntityData()
        {
            richTextBoxObjectData.Text = _selectedEntityCaption + "\n";
            switch (_selectedEntityCaption)
            {
                case countryCaption:
                    foreach (var obj in _dataSet.Countries)
                    {
                        richTextBoxObjectData.AppendText(obj + "\n");
                    }
                    break;
                case geographicalRegionCaption:
                    foreach (var obj in _dataSet.GeographicalRegions)
                    {
                        richTextBoxObjectData.AppendText(obj + "\n");
                    }
                    break;
                case populationCaption:
                    foreach (var obj in _dataSet.Populations)
                    {
                        richTextBoxObjectData.AppendText(obj + "\n");
                    }
                    break;
            }
        }

        private void listBoxEntityObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSelectedObject();
        }

        private void UpdateSelectedObject()
        {
            if (listBoxEntityObjects.SelectedIndex == -1)
            {
                _selectedObject = null;
                return;
            }
            string key = listBoxEntityObjects.SelectedItem.ToString();
            switch (_selectedEntityCaption)
            {
                case countryCaption:
                    _selectedObject = _dataSet.CountryByKey(key);
                    break;
                case geographicalRegionCaption:
                    _selectedObject = _dataSet.GeographicalRegionByKey(key);
                    break;
                case populationCaption:
                    _selectedObject = _dataSet.PopulationByKey(key);
                    break;
            }
            richTextBoxObjectData.Text = _selectedObject.ToString();
        }

        private void richTextBoxObjectData_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        #region Обробники команд меню Файл

        private void menuFileSaveAs_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(dialog.FileName);
            FileIoController.Save(_dataSet, FileName);
            UpdateState();
        }

        private void menuFileSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FileName))
            {
                menuFileSaveAs_Click(sender, e);
            }
            else
            {
                FileIoController.Save(_dataSet, FileName);
            }
            UpdateState();
        }


        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileName = dialog.FileName;
            _dataSet.Clear();
            FileIoController.Load(ref _dataSet, FileName);
            UpdateState();
        }

        private void menuFileSaveAsText_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, _dataSet.ToString());
            }
            UpdateState();
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            FileName = null;
            _dataSet.Clear();
            UpdateState();
        }

        #endregion


        private void CreateEntitiesEditors()
        {
            _fCountriesEditor = new FBindingListEditor<Country>(
                _dataSet.Countries)
            { Text = countryCaption };
            _fGeographicalRegionsEditor = new FBindingListEditor<GeographicalRegion>(
                _dataSet.GeographicalRegions)
            { Text = geographicalRegionCaption };
            _fPopulationsEditor = new FBindingListEditor<Population>(
                _dataSet.Populations)
            { Text = populationCaption };
        }


        private void menuEditingEditEntityData_Click(object sender, EventArgs e)
        {
            switch (_selectedEntityCaption)
            {
                case countryCaption:
                    _fCountriesEditor.ShowDialog();
                    break;
                case geographicalRegionCaption:
                    _fGeographicalRegionsEditor.ShowDialog();
                    break;
                case populationCaption:
                    _fPopulationsEditor.ShowDialog();
                    break;
            }
            UpdateState();
        }

        private void richTextBoxObjectData_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
