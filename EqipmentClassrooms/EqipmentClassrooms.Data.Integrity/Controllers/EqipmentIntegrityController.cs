using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using EqipmentClassrooms.Interfaces;
using Common.Data.Integrity;
using System;

namespace EqipmentClassrooms.Data.Integrity.Controllers
{
    public class EqipmentIntegrityController :
            DataIntegrityController<Eqipment, IEqipmentClassroomsDataSet>
    {
        public EqipmentIntegrityController(IEqipmentClassroomsDataSet dataSet)
            : base(dataSet, dataSet.Eqipmentss)
        {
        }

        public override void EnsureTotalIntegrity()
        {
            //throw new NotImplementedException();
        }

        protected override void EnsureIntegrityOfAdding(Eqipment eqipment)
        {
            //throw new NotImplementedException();
        }

        protected override void EnsureIntegrityOfChanging(Eqipment oldItem, Eqipment newItem)
        {
            if (newItem.Name != oldItem.Name)
            {
                EnsureCascaingUpdate(oldItem, newItem);
            }
        }
        private void EnsureCascaingUpdate(Eqipment oldItem, Eqipment newItem)
        {
            for (int i = 0; i < DataSet.Audiencess.Count; i++)
            {
                if (DataSet.Eqipmentss[i].Name == oldItem.Name)
                    DataSet.Eqipmentss[i].Name = newItem.Name;
            }
        }
        protected override void EnsureIntegrityOfRemoving(Eqipment eqipment)
        {
            EnsureCascaingDelete(eqipment);
        }

        private void EnsureCascaingDelete(Eqipment eqipment)
        {
            List<Eqipment> eqipmentList = DataSet.Eqipmentss
                .Where(e => e.Name == eqipment.Name).ToList();
            for (int i = 0; i < eqipmentList.Count; i++)
            {
                DataSet.Eqipmentss.Remove(eqipmentList[i]);
            }
            eqipmentList.Clear();
        }
    }
}
