using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using Common.Data.Integrity;
using EqipmentClassrooms.Interfaces;

namespace EqipmentClassrooms.Data.Integrity.Controllers
{
    public class AudienceIntegrityController : 
        DataIntegrityController<Audience, IEqipmentClassroomsDataSet>
    {
        public AudienceIntegrityController(IEqipmentClassroomsDataSet dataSet)
            : base(dataSet, dataSet.Audiencess) {
        }

        public override void EnsureTotalIntegrity()
        {
            //throw new NotImplementedException();
        }

        protected override void EnsureIntegrityOfAdding(Audience audience)
        {
            //throw new NotImplementedException();
        }

        protected override void EnsureIntegrityOfChanging(Audience oldItem, Audience newItem)
        {
            if (newItem.Name != oldItem.Name)
            {
                EnsureCascaingUpdate(oldItem, newItem);
            }
        }
        private void EnsureCascaingUpdate(Audience oldItem, Audience newItem)
        {
            for (int i = 0; i < DataSet.Audiencess.Count; i++)
            {
                if (DataSet.Audiencess[i].Name == oldItem.Name)
                    DataSet.Audiencess[i].Name = newItem.Name;
            }
        }
        protected override void EnsureIntegrityOfRemoving(Audience audience)
        {
            EnsureCascaingDelete(audience);
        }

        private void EnsureCascaingDelete(Audience audience)
        {
            List<Audience> audienceList = DataSet.Audiencess
                .Where(e => e.Name == audience.Name).ToList();
            for (int i = 0; i < audienceList.Count; i++)
            {
                DataSet.Audiencess.Remove(audienceList[i]);
            }
            audienceList.Clear();
        }
    }
}
