using Common.Characteristics.Extensions;
using Common.Data;
using Common.Data.FileIO.Interfaces;
using Common.Data.Interfaces;
using Common.Extensions;
using Common.Forms.Editing.Interfaces;
using Common.Interfaces;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Common.Forms.Editing {
    public partial class FEntitiesDataSetEditor : Form {

        private string _title; 

        protected readonly IFileOperationsController _fileOperationsController;
        protected readonly IEntitiesDataSet _dataSet;

        protected IDataSetEditingManager _dataSetEditingManager;
        protected IEntityObjectEditingManager _objectEditingManager;


        protected EntityInfo _entityInfo = null;
        IEntity _entityObject = null;

        //bool _testDataIsLoaded = false;

        public FEntitiesDataSetEditor(
                IFileOperationsController fileOperationsController
            ) {
            #region граничні оператори
            if (fileOperationsController == null) {
                throw new ArgumentNullException("IFileIOController");
            }
            #endregion
            _fileOperationsController = fileOperationsController;
            _dataSet = _fileOperationsController.DataSet;

            InitializeComponent();

            SetToolStripButtonsImages();

            _title = string.Format("Редактор даних ПО \"{0}\"", 
                _dataSet.SubjectAreaName);
            SetControlsState();
            UpdateEntitiesList();
        }

        private void SetControlsState() {
            bool hasOpenedFile = !string.IsNullOrEmpty(
                _fileOperationsController.FileName);
            this.Text = hasOpenedFile ? String.Format("{0}: {1}",
                _title, _fileOperationsController.FileName) : _title;

            SetFileOperationControlsState(hasOpenedFile);
            SetEditingControlsState(hasOpenedFile);
        }

        private void SetFileOperationControlsState(bool hasOpenedFile) {
            menuFileNew.Enabled = !hasOpenedFile ||
                _fileOperationsController.TestDataIsLoaded;
            menuFileOpen.Enabled = !hasOpenedFile;
            menuFileClose.Enabled = hasOpenedFile;
            menuFileSave.Enabled = hasOpenedFile;
            menuFileSaveAs.Enabled = hasOpenedFile ||
                _fileOperationsController.TestDataIsLoaded;
            menuFileSaveCopyAs.Enabled = hasOpenedFile;
            menuFileSaveAsText.Enabled = hasOpenedFile ||
                _fileOperationsController.TestDataIsLoaded;
            menuDataLoadTestData.Enabled = !hasOpenedFile 
                && !_fileOperationsController.TestDataIsLoaded;

            toolStripButtonNew.Enabled = menuFileNew.Enabled;
            toolStripButtonOpen.Enabled = menuFileOpen.Enabled;
            toolStripButtonSave.Enabled = menuFileSave.Enabled;
        }

        private void SetEditingControlsState(bool hasOpenedFile) {
            menuEditingEntityData.Visible =
                _dataSetEditingManager != null && _entityInfo != null;
            menuSeparatorEditingEntityData.Visible = menuEditingEntityData.Visible;
            menuEditingAddObject.Enabled =
                _objectEditingManager != null && _entityInfo != null;
            menuEditingDeleteObject.Enabled =
                _objectEditingManager != null && _entityObject != null;
            menuEditingEditObject.Enabled = menuEditingDeleteObject.Enabled;

            SetEditingButtonsState();
        }

        private void SetEditingButtonsState() {
            toolStripButtonAdd.Enabled = menuEditingAddObject.Enabled;
            toolStripButtonEdit.Enabled = menuEditingEditObject.Enabled;
            toolStripButtonDelete.Enabled = toolStripButtonEdit.Enabled;
        }

        private void SetToolStripButtonsImages() {
            toolStripEditing.ImageList = imageListEditing;
            toolStripButtonAdd.ImageKey = "add";
            toolStripButtonEdit.ImageKey = "edit";
            toolStripButtonDelete.ImageKey = "delete";
        }

        private void UpdateEntitiesList() {
            listBoxEntities.Items.AddRange(_dataSet.EntityCaptions.ToArray());
            if(listBoxEntities.Items.Count > 0) {
                listBoxEntities.SelectedIndex = 0;
            }
        }

        void ShowStatusMessage(string message) {
            toolStripStatusLabelMessage.Text = message;
        }

        private void FEntitiesDataSetBrowser_Load(object sender, EventArgs e) {
            richTextBoxObjectData_Resize(sender, e);
        }

        private void listBoxEntities_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateState();
        }

        void UpdateState() {
            UpdateObjectsList();
            ShowData();
            SetControlsState();
        }

        private void UpdateObjectsList() {
            listBoxEntityObjects.Items.Clear();
            if (listBoxEntities.SelectedIndex == -1) {
                _entityInfo = null;
                return;
            }
            string entityCaption = listBoxEntities.SelectedItem.ToString();
            _entityInfo = _dataSet.EntityInfoByEntityCaption(entityCaption);
            listBoxEntityObjects.Items.AddRange(_entityInfo.Objects
                .Select(e => e.Key).OrderBy(e => e).ToArray());
            UpdateObject();
        }

        private void UpdateObject() {
            if (listBoxEntityObjects.SelectedIndex == -1) {
                _entityObject = null;
                return;
            }
            string key = listBoxEntityObjects.SelectedItem.ToString();
            _entityObject = _entityInfo.Objects.FirstOrDefault(
                e => e.Key == key);
            ShowData();
        }

        private void ShowData() {
            if (_entityInfo == null) {
                richTextBoxObjectData.Text = "";
            } else if (_entityObject == null) {
                richTextBoxObjectData.Text = 
                    _entityInfo.Objects.ToObjectsString(_entityInfo.EntityCaption);
            } else {
                richTextBoxObjectData.Text = _entityObject.ToFullInfoString();
            }
        }

        public IDataSetEditingManager DataSetEditingManager {
            get { return _dataSetEditingManager; }
            set {
                if (value == null) {
                    throw new ArgumentNullException("DataSetEditingManager");
                }
                _dataSetEditingManager = value;
                _dataSetEditingManager.DataSet = _dataSet;
                SetControlsState();
            }
        }

        public IEntityObjectEditingManager ObjectEditingManager {
            get { return _objectEditingManager; }
            set {
                if (value == null) {
                    throw new ArgumentNullException("ObjectEditingManager");
                }
                _objectEditingManager = value;
                _objectEditingManager.DataSet = _dataSet;
                SetControlsState();
            }
        }

        private void menuDataLoadTestData_Click(object sender, EventArgs e) {
            if (!_fileOperationsController.LoadTestData()) return;
            UpdateState();
        }

        private void listBoxEntityObjects_SelectedIndexChanged(object sender, EventArgs e) {
            UpdateObject();
            SetControlsState();
        }

        private void richTextBoxObjectData_Resize(object sender, EventArgs e) {
            ShowData();
        }

        private void menuEditingEditEntityData_Click(object sender, EventArgs e) {
            if (_entityInfo == null || DataSetEditingManager == null)
                return;
            DataSetEditingManager.ShowEntityDataEditor(_entityInfo.EntityCaption);
            UpdateState();
        }

        private void menuFileNew_Click(object sender, EventArgs e) {
            _fileOperationsController.New();
            UpdateState();
        }

        private void menuFileOpen_Click(object sender, EventArgs e) {
            _fileOperationsController.Open();
            UpdateState();
        }

        private void menuFileSave_Click(object sender, EventArgs e) {
            _fileOperationsController.Save();
            UpdateState();
        }

        private void menuFileSaveAs_Click(object sender, EventArgs e) {
            _fileOperationsController.SaveAs();
            UpdateState();
        }

        private void menuFileSaveAsText_Click(object sender, EventArgs e) {
            _fileOperationsController.SaveAsText();
            UpdateState();
        }

        private void menuFileClose_Click(object sender, EventArgs e) {
            _fileOperationsController.Close();
            UpdateState();
        }

        private void richTextBoxObjectData_LinkClicked(object sender, LinkClickedEventArgs e) {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void menuEditingAddObject_Click(object sender, EventArgs e) {
            if (_entityInfo == null || ObjectEditingManager == null)
                return;
            try {
                if (ObjectEditingManager.AddObject(_entityInfo.EntityTypeName))
                    UpdateState();
            } catch (Exception ex) {
                //ShowStatusMessage(ex.Message);
                MessageBox.Show(this, ex.Message, "Помилка додання об'єкта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuEditingEditObject_Click(object sender, EventArgs e) {
            if (_entityObject == null || ObjectEditingManager == null)
                return;
            try {
                if (ObjectEditingManager.EditObject(_entityObject))
                    UpdateState();
            } catch (Exception ex) {
                //ShowStatusMessage(ex.Message);
                MessageBox.Show(this, ex.Message, "Помилка редагування об'єкта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuEditingDeleteObject_Click(object sender, EventArgs e) {
            if (_entityObject == null || ObjectEditingManager == null)
                return;
            try {
                if (ObjectEditingManager.DeleteObject(_entityObject))
                    UpdateState();
            } catch (Exception ex) {
                //ShowStatusMessage(ex.Message);
                MessageBox.Show(this, ex.Message, "Помилка видалення об'єкта",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void menuFileExit_Click(object sender, EventArgs e) {
            Close();
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {

        }

        private void richTextBoxObjectData_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuFileSaveCopyAs_Click(object sender, EventArgs e)
        {

        }
    }
}
