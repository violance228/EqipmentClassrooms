using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using EqipmentClassrooms.Interfaces;
using Common.Data.Integrity;
using System;

namespace EqipmentClassrooms.Data.Integrity.Controllers
{
    public class EqipmentAudienceIntegrityController
        : DataIntegrityController<EqipmentAudience, IEqipmentClassroomsDataSet>
    {
        public EqipmentAudienceIntegrityController(IEqipmentClassroomsDataSet dataSet)
            : base(dataSet, dataSet.EqipmentAudiencess) { }

        public override void EnsureTotalIntegrity()
        {
            //throw new NotImplementedException();
        }
        protected override void EnsureIntegrityOfAdding(EqipmentAudience eqipmentaudience)
        {
            //throw new NotImplementedException();
        }
        protected override void EnsureIntegrityOfChanging(EqipmentAudience oldItem, EqipmentAudience newItem)
        {
            if (newItem.Name != oldItem.Name)
            {
                EnsureCascaingUpdate(oldItem, newItem);
            }
        }


        private void EnsureCascaingUpdate(EqipmentAudience oldItem,
            EqipmentAudience newItem)
        {
            for (int i = 0; i < DataSet.EqipmentAudiencess.Count; i++)
            {
                if (DataSet.EqipmentAudiencess[i].Name == oldItem.Name)
                    DataSet.EqipmentAudiencess[i].Name = newItem.Name;
            }
        }
        protected override void EnsureIntegrityOfRemoving(EqipmentAudience eqipmentaudience)
        {
            EnsureCascaingDelete(eqipmentaudience);
        }
        private void EnsureCascaingDelete(EqipmentAudience eqipmentaudience)
        {
            List<EqipmentAudience> eqipmentAudienceList = DataSet.EqipmentAudiencess
                .Where(e => e.Name == eqipmentaudience.Name).ToList();
            for (int i = 0; i < eqipmentAudienceList.Count; i++)
            {
                DataSet.EqipmentAudiencess.Remove(eqipmentAudienceList[i]);
            }
            eqipmentAudienceList.Clear();
        }

    }
}
