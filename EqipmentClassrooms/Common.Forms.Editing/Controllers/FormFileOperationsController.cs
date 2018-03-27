using Common.Data.FileIO.Interfaces;
using Common.Data.Interfaces;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Common.Forms.Editing.Controllers
{
    public class FormFileOperationsController : IFileOperationsController
    {

        public event EventHandler<EventArgs> DataLoaded;

        public void OnDataLoaded()
        {
            if (DataLoaded != null)
            {
                DataLoaded(this, new EventArgs());
            }
        }

        public string FileName { get; set; }
        public string FileFilter { get; set; }

        private IEntitiesDataSet _dataSet;

        public IEntitiesDataSet DataSet
        {
            get { return _dataSet; }
        }

        private IFileIoController _fileIoController;

        bool _testDataIsLoaded = false;

        public bool TestDataIsLoaded
        {
            get { return _testDataIsLoaded; }
        }

        public FormFileOperationsController(IEntitiesDataSet dataSet,
            IFileIoController fileIoController)
        {
            //
            _dataSet = dataSet;
            FileIoController = fileIoController;
            DefaultFileName = "DataFile";
        }

        public IFileIoController FileIoController
        {
            get { return _fileIoController; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("FileIoController");
                }
                _fileIoController = value;
                SetFileFilter();
            }
        }

        private void SetFileFilter()
        {
            FileFilter = string.Format("{0} (*{1})|*{1}",
                _fileIoController.FileTypeCaption,
                _fileIoController.FileExtension);
        }

        public string DefaultFileName { get; set; }

        private string _directory;

        public string Directory
        {
            get
            {
                if (string.IsNullOrWhiteSpace(_directory))
                {
                    _directory = Path.GetDirectoryName(
                        Assembly.GetExecutingAssembly().Location);
                }
                return _directory;
            }
            set
            {
                if (!System.IO.Directory.Exists(value))
                {
                    System.IO.Directory.CreateDirectory(value);
                }
                _directory = value;
            }
        }

        void ClearData()
        {
            _dataSet.Clear();
            _testDataIsLoaded = false;
        }

        public bool LoadTestData()
        {
            if (_testDataIsLoaded || !string.IsNullOrWhiteSpace(FileName))
                return false;
            _dataSet.CreateTestData();
            _testDataIsLoaded = true;
            OnDataLoaded();
            return true;
        }

        public void New()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Створення файла даних";
            dialog.FileName = FileName ?? DefaultFileName;
            dialog.DefaultExt = _fileIoController.FileExtension;
            dialog.Filter = FileFilter;
            dialog.InitialDirectory = Directory;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(dialog.FileName);
            ClearData();
            SaveData();
        }

        private void SaveData()
        {
            try
            {
                _fileIoController.Save(_dataSet, FileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка збереження даних",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Save()
        {
            if (string.IsNullOrEmpty(FileName))
            {
                SaveAs();
            }
            else
            {
                SaveData();
            }
        }

        public void SaveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Збереження файла даних";
            dialog.FileName = FileName ?? DefaultFileName;
            dialog.DefaultExt = _fileIoController.FileExtension;
            dialog.Filter = FileFilter;
            dialog.InitialDirectory = Directory;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileName = Path.GetFullPath(dialog.FileName);
            SaveData();
        }

        public void SaveAsText()
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title =
                "Зберегти текстове представлення даних у файл";
            dialog.FileName = FileName ?? DefaultFileName;
            dialog.DefaultExt = ".txt";
            dialog.Filter = "Текстові файли (*.txt)|*.txt";
            dialog.InitialDirectory = Directory;
            dialog.RestoreDirectory = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(dialog.FileName, _dataSet.ToString());
            }
        }

        public void Open()
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Відкриття файла даних";
            dialog.Filter = FileFilter;
            dialog.InitialDirectory = Directory;
            if (dialog.ShowDialog() != DialogResult.OK)
                return;
            FileName = dialog.FileName;
            ClearData();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                _fileIoController.Load(ref _dataSet, FileName);
                OnDataLoaded();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка завантаження даних",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Close()
        {
            FileName = null;
            ClearData();
        }

    }
}
