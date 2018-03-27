using Common.Data.Interfaces;
using System;
using System.ComponentModel;
using EqipmentClassrooms.Domain;

namespace EqipmentClassrooms.Interfaces
{
    public interface IEqipmentClassroomsDataSet : IEntitiesDataSet
    {
        BindingList<Audience> Audiencess { get; }
        BindingList<AudienceEqipmentTypes> AudienceEqipmentTypes { get; }
        BindingList<AudienceType> AudienceTypess { get; }
        BindingList<Eqipment> Eqipmentss { get; }
        BindingList<EqipmentAudience> EqipmentAudiencess { get; }
        BindingList<EqipmentType> EqipmentTypess { get; }

        //Audience AudienceByKeyElements(decimal number, string nameTypeAudience);
        //AudienceEqipmentTypes AudienceEqipmentTypeByKeyEqlements(string nameTypeEqipment, string nameTypeAudience);
        //AudienceType AudienceTypeByNameTypeAudience(string nameTypeAudience);
        //Eqipment EqipmentByKeyElements(DateTime date,string eqipmentNameType);
        //EqipmentType EqipmentTypeByKeyElements(decimal name, string eqipmentNameType);
        //EqipmentAudience EqipmentAudienceByKeyElements(int number1, string eqipmentNameType, double inventoryNumber);
    }
}
