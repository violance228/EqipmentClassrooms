using System;
using EqipmentClassrooms.Data.Integrity.Controllers;
using EqipmentClassrooms.Interfaces;

namespace EqipmentClassrooms.Data.Integrity
{
    public class EqipmentClassroomsIntagrityManager
    {
        private AudienceIntegrityController
           _audienceIntegrityController;
        private AudienceEqipmentTypesIntegrityController
            _audienceeqipmenttypesIntegrityController;
        private AudienceTypeIntegrityController
            _audiencetypeIntegrityController;
        private EqipmentIntegrityController
            _eqipmentIntegrityController;
        private EqipmentAudienceIntegrityController
            _eqipmentaudienceIntegrityController;
        private EqipmentTypeIntegrityController
            _eqipmenttypeIntegrityController;

        private readonly IEqipmentClassroomsDataSet _dataSet;

        public EqipmentClassroomsIntagrityManager(IEqipmentClassroomsDataSet dataSet)
        {
            if (dataSet == null)
            {
                throw new ArgumentException
                    ("Потрібно вказати обєкт набору даних");
                 _dataSet = dataSet;
                CreateControllers();
            }
        }
        private void CreateControllers()
        {
            _audienceIntegrityController =
                new AudienceIntegrityController(_dataSet);
            _audienceeqipmenttypesIntegrityController =
                new AudienceEqipmentTypesIntegrityController(_dataSet);
            _audiencetypeIntegrityController =
                new AudienceTypeIntegrityController(_dataSet);
            _eqipmentIntegrityController =
                new EqipmentIntegrityController(_dataSet);
            _eqipmentaudienceIntegrityController =
                new EqipmentAudienceIntegrityController(_dataSet);
            _eqipmenttypeIntegrityController =
                new EqipmentTypeIntegrityController(_dataSet);
        }
        private bool _autoEnsuringIntegrity;

        public bool AutoEnsuringIntegrity
        {
            get
            {
                return _autoEnsuringIntegrity;
            }
            set
            {
                _autoEnsuringIntegrity = value;
                SetControllersAutoEnsuringIntegrity();
            }
        }
        private void SetControllersAutoEnsuringIntegrity()
        {
            _audienceIntegrityController.AutoEnsuringIntegrity =
                _autoEnsuringIntegrity;
            _audienceeqipmenttypesIntegrityController.AutoEnsuringIntegrity =
                _autoEnsuringIntegrity;
            _audiencetypeIntegrityController.AutoEnsuringIntegrity =
                _autoEnsuringIntegrity;
            _eqipmentIntegrityController.AutoEnsuringIntegrity =
                _autoEnsuringIntegrity;
            _eqipmentaudienceIntegrityController.AutoEnsuringIntegrity =
                _autoEnsuringIntegrity;
            _eqipmenttypeIntegrityController.AutoEnsuringIntegrity =
                _autoEnsuringIntegrity;
        }
        public void EnsureTotalIntegrity()
        {
            _audienceIntegrityController.EnsureTotalIntegrity();
            _audienceeqipmenttypesIntegrityController.EnsureTotalIntegrity();
            _audiencetypeIntegrityController.EnsureTotalIntegrity();
            _eqipmentIntegrityController.EnsureTotalIntegrity();
            _eqipmentaudienceIntegrityController.EnsureTotalIntegrity();
            _eqipmenttypeIntegrityController.EnsureTotalIntegrity();
        }
    }
}
