using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using Common.Data.Integrity;
using EqipmentClassrooms.Interfaces;

namespace EqipmentClassrooms.Data.Integrity.Controllers
{
    public class AudienceTypeIntegrityController : 
        DataIntegrityController<AudienceType, IEqipmentClassroomsDataSet>
    {
        public AudienceTypeIntegrityController(IEqipmentClassroomsDataSet dataSet)
            : base(dataSet, dataSet.AudienceTypess) {
        }
        public override void EnsureTotalIntegrity()
        {
            //throw new NotImplementedException();
        }

        protected override void EnsureIntegrityOfAdding(AudienceType audiencetype)
        {
            //throw new NotImplementedException();
        }

        protected override void EnsureIntegrityOfChanging(AudienceType oldItem, AudienceType newItem)
        {
            if (newItem.Name != oldItem.Name)
            {
                EnsureCascaingUpdate(oldItem, newItem);
            }
        }

        private void EnsureCascaingUpdate(AudienceType oldItem, AudienceType newItem)
        {
            for (int i = 0; i < DataSet.AudienceTypess.Count; i++)
            {
                if (DataSet.AudienceTypess[i].Name == oldItem.Name)
                    DataSet.AudienceTypess[i].Name = newItem.Name;
            }
        }

        protected override void EnsureIntegrityOfRemoving(AudienceType audiencetype)
        {
            EnsureCascaingDelete(audiencetype);
        }
        private void EnsureCascaingDelete(AudienceType audiencetype)
        {
            List<AudienceType> audienceTypeList = DataSet.AudienceTypess
                .Where(e => e.Name == audiencetype.Name).ToList();
            for (int i = 0; i < audienceTypeList.Count; i++)
            {
                DataSet.AudienceTypess.Remove(audienceTypeList[i]);
            }
            audienceTypeList.Clear();
        }
    }
}
