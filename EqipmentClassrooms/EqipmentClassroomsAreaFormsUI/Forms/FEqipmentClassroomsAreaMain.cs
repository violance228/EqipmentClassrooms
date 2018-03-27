using Common.Data.FileIO.Interfaces;
using Common.Forms.TextBrowsing;
using Common.Forms.Editing;
using EqipmentClassrooms.Data;
using EqipmentClassrooms.Interfaces;
using System;
using System.Windows.Forms;
using Common.Forms.Interfaces;

namespace EqipmentClassroomsAreaFormsUI.Forms
{
    public partial class FEqipmentClassroomsAreaMain : Form
    {

        private string _title;

        protected readonly IFileOperationsController _fileOperationsController;
        protected readonly IEqipmentClassroomsDataSet _dataSet;

        protected FEntitiesDataSetEditor _dataSetEditor;

        protected IInfoDialog _infoDialog;

        public FEqipmentClassroomsAreaMain(IFileOperationsController fileOperationsController)
        {
            if (fileOperationsController == null)
            {
                throw new ArgumentNullException("IFileIOController");
            }
            _fileOperationsController = fileOperationsController;
            _dataSet = _fileOperationsController.DataSet as EqipmentClassroomsDataSet;
            if (_dataSet == null)
            {
                throw new ArgumentNullException("EqipmentClassroomsDataSet");
            }
            _title = string.Format("Дані ПО \"{0}\"", _dataSet.SubjectAreaName);

            InitializeComponent();

            SetControlsState();
        }
        private void SetControlsState()
        {
            bool hasOpenedFile = !string.IsNullOrEmpty(
                _fileOperationsController.FileName);
            this.Text = hasOpenedFile ? string.Format("{0}: {1}",
                _title, _fileOperationsController.FileName) : _title;

            SetFileOperationControlsState(hasOpenedFile);
            menuDataEdit.Enabled = _dataSetEditor != null;
            toolStripButtonDataEdit.Enabled = menuDataEdit.Enabled;
        }
        private void SetFileOperationControlsState(bool hasOpenedFile)
        {
            menuFileOpen.Enabled = !hasOpenedFile;
            menuFileClose.Enabled = hasOpenedFile;
            toolStripButtonOpen.Enabled = menuFileOpen.Enabled;
            toolStripButtonClose.Enabled = menuFileClose.Enabled;
        }

        void ShowStatusMessage(string message)
        {
            toolStripStatusLabelMessage.Text = message;
        }

        void UpdateState()
        {
            //UpdateObjectsList();
            //ShowData();
            SetControlsState();
        }

        public FEntitiesDataSetEditor DataSetEditor
        {
            get { return _dataSetEditor; }
            set
            {
                _dataSetEditor = value;
                SetControlsState();
            }
        }

        public IInfoDialog InfoDialog
        {
            get
            {
                if (_infoDialog == null)
                {
                    _infoDialog = new FTextInfo()
                    {
                        Title = "Текстове представлення даних ПО \"Обладнання аудиторій\""
                    };
                }
                return _infoDialog;
            }
            set { _infoDialog = value; }
        }

        private void FEqipmentClassroomsAreaMain_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            _fileOperationsController.Open();
            UpdateState();
        }

        private void toolStripButtonClose_Click(object sender, EventArgs e)
        {
            _fileOperationsController.Close();
            UpdateState();
        }

        private void toolStripButtonDataEdit_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButtonDataAsText_Click(object sender, EventArgs e)
        {

        }

        private void menuFile_Click(object sender, EventArgs e)
        {

        }

        private void menuData_Click(object sender, EventArgs e)
        {

        }

        private void menuWindow_Click(object sender, EventArgs e)
        {

        }

        private void menuHelp_Click(object sender, EventArgs e)
        {

        }

        private void menuFileOpen_Click(object sender, EventArgs e)
        {
            _fileOperationsController.Open();
            UpdateState();
        }

        private void menuFileClose_Click(object sender, EventArgs e)
        {
            _fileOperationsController.Close();
            UpdateState();
        }

        private void menuFileExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuDataEdit_Click(object sender, EventArgs e)
        {
            if (DataSetEditor != null)
                DataSetEditor.ShowDialog();
            UpdateState();
        }

        private void menuDataAsText_Click(object sender, EventArgs e)
        {
            InfoDialog.Information = _dataSet.ToString();
            InfoDialog.ShowDialog();
        }

        private void menuDataLoadTestData_Click(object sender, EventArgs e)
        {
            if (!_fileOperationsController.LoadTestData()) return;
            menuDataLoadTestData.Enabled = false;
            UpdateState();
        }

        private void menuWindowCascade_Click(object sender, EventArgs e)
        {

        }

        private void menuWindowTileVertical_Click(object sender, EventArgs e)
        {

        }

        private void menuWindowTileHorizontal_Click(object sender, EventArgs e)
        {

        }

        private void menuWindowArrangeIcons_Click(object sender, EventArgs e)
        {

        }
        private FEqipmentClassroomsAreaAboutBox _aboutBox;

        private void menuHelpAbout_Click(object sender, EventArgs e)
        {
            if (_aboutBox == null)
            {
                _aboutBox = new FEqipmentClassroomsAreaAboutBox();
            }
            _aboutBox.ShowDialog();
        }
    }
}
