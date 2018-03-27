using System;
using System.Linq;
using System.ComponentModel;
using EqipmentClassrooms.Domain;

namespace EqipmentClassrooms.Data
{
    partial class EqipmentClassroomsDataSet
    {
        private readonly BindingList<Audience> _audiencess =
            new BindingList<Audience>();

        public BindingList<Audience> Audiencess
        {
            get { return _audiencess; }
        }

        private readonly BindingList<AudienceEqipmentTypes> _audienceEqipmentTypess =
                new BindingList<AudienceEqipmentTypes>();

        public BindingList<AudienceEqipmentTypes> AudienceEqipmentTypes
        {
            get { return _audienceEqipmentTypess; }
        }
        private readonly BindingList<AudienceType> _audiencetypess =
                new BindingList<AudienceType>();

        public BindingList<AudienceType> AudienceTypess
        {
            get { return _audiencetypess; }
        }
        private readonly BindingList<Eqipment> _eqipmentss =
                new BindingList<Eqipment>();

        public BindingList<Eqipment> Eqipmentss
        {
            get { return _eqipmentss; }
        }
        private readonly BindingList<EqipmentAudience> _eqipmentaudiencess =
                       new BindingList<EqipmentAudience>();

        public BindingList<EqipmentAudience> EqipmentAudiencess
        {
            get { return _eqipmentaudiencess; }
        }
        private readonly BindingList<EqipmentType> _eqipmenttypess =
               new BindingList<EqipmentType>();

        public BindingList<EqipmentType> EqipmentTypess
        {
            get { return _eqipmenttypess; }
        }
        public void Clear()
        {
            Audiencess.Clear();
            AudienceEqipmentTypes.Clear();
            AudienceTypess.Clear();
            Eqipmentss.Clear();
            EqipmentAudiencess.Clear();
            EqipmentTypess.Clear();
        }
        public Audience AudienceByKeyElements(string name, string nameTypeAudience)
        {
            return Audiencess.FirstOrDefault(
                e => e.Name == name && e.NameTypeAudience == nameTypeAudience);
        }
        public AudienceEqipmentTypes AudienceEqipmentTypesByKeyElements(string name, string nameTypeAudience, string nameTypeEqipment)
        {
            return AudienceEqipmentTypes.FirstOrDefault(
                e => e.Name == name && e.NameTypeAudience == nameTypeAudience && e.NameTypeEqipment == nameTypeEqipment);
        }
        public AudienceType AudienceTypeByNameTypeAudience( string nameTypeAudience)
        {
            return AudienceTypess.FirstOrDefault(
               (e => e.NameTypeAudience == nameTypeAudience));
        }
        public Eqipment EqipmentTypeByKeyElements(string name, DateTime date)
        {
            return Eqipmentss.FirstOrDefault(
                e => e.Name == name && e.Date == date);
        }
        public EqipmentAudience EqipmentAudienceTypeByKeyElements(string name, string eqipmentNameType)
        {
            return EqipmentAudiencess.FirstOrDefault(
                e => e.Name == name && e.EqipmentNameType == eqipmentNameType);
        }
        public EqipmentType EqipmentTypeByKeyElements(string name,string eqipmentNameType)
        {
            return EqipmentTypess.FirstOrDefault(
                e => e.Name == name && e.EqipmentNameType == eqipmentNameType);
        }
    }
}
