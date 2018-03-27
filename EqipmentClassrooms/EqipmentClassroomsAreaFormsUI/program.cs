using Common.Data.FileIO.Interfaces;
using Common.Forms.Editing.Controllers;
using Common.Forms.Editing;
using EqipmentClassrooms.Data;
using EqipmentClassroomsAreaFormsUI.Managers;
using System;
using System.Windows.Forms;
using Common.Forms.Editing.Interfaces;
using EqipmentClassrooms.FileIO;
using EqipmentClassrooms.Data.Integrity;
using EqipmentClassroomsAreaFormsUI.Forms;
using System.Drawing;
using EqipmentClassroomsAreaFormsUI.Properties;
using EqipmentClassrooms.Interfaces;

namespace EqipmentClassroomsAreaFormsUI
{
    static class Program
    {
        static IEqipmentClassroomsDataSet _dataSet = new EqipmentClassroomsDataSet();
        static IDataSetEditingManager _dataSetEditingManager =
            new EqipmentClassroomsDataSetEditingManager();
        static FEntitiesDataSetEditor _fEntitiesDataSetEditor;
        static IFileIoController<IEqipmentClassroomsDataSet> _fileIoController;
        static IFileOperationsController _fileOperationsController;
        static IEntityObjectEditingManager _objectEditingManager =
            new EqipmentClassroomsObjectEditingManager();
        static EqipmentClassroomsIntagrityManager _integrityManager;

        static FEqipmentClassroomsAreaMain _fMain;


        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            _fileIoController = new EqipmentClassroomsXmlFileIoController();
            _fileOperationsController = new FormFileOperationsController(
                _dataSet, _fileIoController)
            {
                DefaultFileName = "EqipmentClassrooms"
            };
            _fEntitiesDataSetEditor = new FEntitiesDataSetEditor(_fileOperationsController);
            _fEntitiesDataSetEditor.ObjectEditingManager = _objectEditingManager;
            _fEntitiesDataSetEditor.DataSetEditingManager = _dataSetEditingManager;//

            _integrityManager = new EqipmentClassroomsIntagrityManager(_dataSet);

            _fMain = new FEqipmentClassroomsAreaMain(_fileOperationsController);
            _fMain.DataSetEditor = _fEntitiesDataSetEditor;




            //Application.Run(new Form1());
            Application.Run(_fMain);
        }

    }
}
