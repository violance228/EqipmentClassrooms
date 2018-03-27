using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using EqipmentClassrooms.Interfaces;
using Common.Data.Integrity;
using System;

namespace EqipmentClassrooms.Data.Integrity.Controllers
{
    public class AudienceEqipmentTypesIntegrityController 
        : DataIntegrityController<AudienceEqipmentTypes, IEqipmentClassroomsDataSet>
    {
        public AudienceEqipmentTypesIntegrityController(IEqipmentClassroomsDataSet dataSet)
            : base(dataSet, dataSet.AudienceEqipmentTypes) { }

        public override void EnsureTotalIntegrity()
        {
            //throw new NotImplementedException();
        }
        protected override void EnsureIntegrityOfAdding(AudienceEqipmentTypes audienceeqipmenttypes)
        {
            //throw new NotImplementedException();
        }
        protected override void EnsureIntegrityOfChanging(AudienceEqipmentTypes oldItem, AudienceEqipmentTypes newItem)
        {
            if (newItem.Name != oldItem.Name)
            {
                EnsureCascaingUpdate(oldItem, newItem);
            }
        }


        private void EnsureCascaingUpdate( AudienceEqipmentTypes oldItem,
            AudienceEqipmentTypes newItem)
        {            
            for (int i = 0; i < DataSet.AudienceEqipmentTypes.Count; i++)
            {
                if (DataSet.AudienceEqipmentTypes[i].Name == oldItem.Name)
                    DataSet.AudienceEqipmentTypes[i].Name = newItem.Name;
            }
        }
        protected override void EnsureIntegrityOfRemoving(AudienceEqipmentTypes audienceeqipmenttypes)
        {
            EnsureCascaingDelete(audienceeqipmenttypes);
        } 
        private void EnsureCascaingDelete(AudienceEqipmentTypes audienceeqipmenttypes)
        {
            List<AudienceEqipmentTypes> audienceEqipmentTypesList = DataSet.AudienceEqipmentTypes
                .Where(e => e.Name == audienceeqipmenttypes.Name).ToList();
            for (int i = 0; i < audienceEqipmentTypesList.Count; i++)
            {
                DataSet.AudienceEqipmentTypes.Remove(audienceEqipmentTypesList[i]);
            }
            audienceEqipmentTypesList.Clear();
        }
    }
}
