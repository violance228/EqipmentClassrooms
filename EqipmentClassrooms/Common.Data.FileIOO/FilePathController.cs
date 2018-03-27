using Common.Data.FileIO.Interfaces;
using System;
using System.IO;
using System.Reflection;

namespace Common.Data.FileIO
{

    public class FilePathController : IFilePathController
    {

        private static string _defaultDirectoryName;

        public static string DefaultDirectoryName
        {
            get { return _defaultDirectoryName; }
            set { _defaultDirectoryName = value; }
        }

        static FilePathController()
        {
            _defaultDirectoryName = "uoW";
        }

        private string _filePath;

        public string FilePath
        {
            get { return _filePath; }
        }

        private string _directoryName;

        public string DirectoryName
        {
            get
            {
                if (String.IsNullOrEmpty(_directoryName))
                {
                    SetDirectoryName(CreateDirectoryName());
                }
                return _directoryName;
            }
            set
            {
                SetDirectoryName(String.IsNullOrWhiteSpace(value)
                    ? CreateDirectoryName() : value.Trim());
            }
        }

        private string CreateDirectoryName()
        {
            string exeName = Assembly.GetExecutingAssembly().Location;
            //Environment.GetCommandLineArgs()[0]
            return Path.GetDirectoryName(exeName)
                + "\\" + DefaultDirectoryName;
        }

        private void SetDirectoryName(string value)
        {
            _directoryName = Path.GetFullPath(value);
            if (!Directory.Exists(_directoryName))
            {
                Directory.CreateDirectory(_directoryName);
            }
            _filePath = _directoryName + "\\";
        }

        private string baseFileName;
        public string BaseFileName
        {
            get { return baseFileName; }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(
                        "FileController.BaseFileName: value",
                        "Спроба призначити не визначене "
                        + "базове ім'я файлу");
                }
                baseFileName = value.Trim();
            }
        }

        public FilePathController(string baseFileName)
        {
            this.BaseFileName = baseFileName;
        }


        public void PrepareFileNameToSave(ref string fileName,
            string requiredFileExt)
        {
            CheckAndCreateFileName(ref fileName, requiredFileExt);
            PrepareFilePathToSave(ref fileName);
        }


        public void PrepareFileNameToLoad(ref string fileName,
            string requiredFileExt)
        {
            CheckAndCreateFileName(ref fileName, requiredFileExt);
            PrepareFilePathToLoad(ref fileName);
        }

        private void CheckAndCreateFileName(ref string fileName,
            string requiredFileExt)
        {
            fileName = (fileName ?? "").Trim();
            if (fileName == "")
            {
                fileName = CreateFileName(requiredFileExt);
            }
            else
            {
                PrepareFileExtension(ref fileName, requiredFileExt);
            }
        }

        public string CreateFileName(string fileExt)
        {
            string fileName;
            uint i = 1;
            do
            {
                fileName = String.Format("{0}{1}{2}{3}",
                    FilePath, baseFileName,
                    (i++).ToString(), fileExt);
            } while (File.Exists(fileName));
            return fileName;
        }

        private void PrepareFileExtension(ref string fileName,
                string requiredFileExt)
        {
            string ext = Path.GetExtension(fileName).ToLower();
            if (String.IsNullOrEmpty(ext))
            {
                fileName += requiredFileExt;
            }
            else if (ext != requiredFileExt)
            {
                throw new InvalidOperationException(
                    "Помилка файлового введення/виведення: "
                    + " розширення файлу \"" + fileName
                    + "\" не співпадає з очікуваним (\""
                    + requiredFileExt + "\")");
            }
        }

        private void PrepareFilePathToSave(ref string fileName)
        {
            string dirName = Path.GetDirectoryName(fileName);
            if (dirName == "")
            {
                fileName = FilePath + fileName;
            }
            else if (!System.IO.Directory.Exists(dirName))
            {
                System.IO.Directory.CreateDirectory(dirName);
            }
        }

        private void PrepareFilePathToLoad(ref string fileName)
        {
            if (Path.GetDirectoryName(fileName) == "")
            {
                fileName = FilePath + fileName;
            }
            if (!File.Exists(fileName))
            {
                throw new FileNotFoundException(
                    "Помилка файлового введення: "
                    + "не знайдено файл " + fileName);
            }
        }
    }
}
