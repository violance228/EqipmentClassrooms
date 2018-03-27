using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;
using EqipmentClassrooms.Interfaces;
using Common.Data.Integrity;
using System;

namespace EqipmentClassrooms.Data.Integrity.Controllers
{
    public class EqipmentTypeIntegrityController :
            DataIntegrityController<EqipmentType, IEqipmentClassroomsDataSet>
    {
        public EqipmentTypeIntegrityController(IEqipmentClassroomsDataSet dataSet)
            : base(dataSet, dataSet.EqipmentTypess) {
    }

    public override void EnsureTotalIntegrity()
    {
        //throw new NotImplementedException();
    }

    protected override void EnsureIntegrityOfAdding(EqipmentType eqipmenttype)
    {
        //throw new NotImplementedException();
    }

    protected override void EnsureIntegrityOfChanging(EqipmentType oldItem, EqipmentType newItem)
    {
        if (newItem.Name != oldItem.Name)
        {
            EnsureCascaingUpdate(oldItem, newItem);
        }
    }
    private void EnsureCascaingUpdate(EqipmentType oldItem, EqipmentType newItem)
    {
        for (int i = 0; i < DataSet.EqipmentTypess.Count; i++)
        {
            if (DataSet.EqipmentTypess[i].Name == oldItem.Name)
                DataSet.EqipmentTypess[i].Name = newItem.Name;
        }
    }
    protected override void EnsureIntegrityOfRemoving(EqipmentType eqipmenttype)
    {
        EnsureCascaingDelete(eqipmenttype);
    }

    private void EnsureCascaingDelete(EqipmentType eqipmentype)
    {
        List<EqipmentType> eqipmentTypeList = DataSet.EqipmentTypess
            .Where(e => e.Name == eqipmentype.Name).ToList();
        for (int i = 0; i < eqipmentTypeList.Count; i++)
        {
            DataSet.EqipmentTypess.Remove(eqipmentTypeList[i]);
        }
        eqipmentTypeList.Clear();
    }
}
}
