using System.Linq;
using Common.Data;
using Common.Data.Interfaces;
using Common.Interfaces;
using System.Collections.Generic;
using System;
using EqipmentClassrooms.Interfaces;
using EqipmentClassrooms.Domain;

namespace EqipmentClassrooms.Data
{
    public partial class EqipmentClassroomsDataSet : IEqipmentClassroomsDataSet
    {
        public string SubjectAreaName { get; set; }
        public EqipmentClassroomsDataSet(string subjectAreaBane)
        {
            SubjectAreaName = subjectAreaBane;
            CreateEntitiesInfo();
        }
        public EqipmentClassroomsDataSet() : this("Обладнання") { }

        private readonly Dictionary<string, EntityInfo>
          _entitiesInfoDictionary = new Dictionary<string, EntityInfo>();

        public IEnumerable<string> EntityCaptions
        {
            get
            {
                return _entitiesInfoDictionary
                    .Select(e => e.Value.EntityCaption);
            }
        }
        public IEnumerable<EntityInfo> EntitiesInfo
        {
            get
            {
                return _entitiesInfoDictionary.Values;
            }
        }
        public IEnumerable<IEntity> ObjectsByEntityCaption(string entityCaption)
        {
            return _entitiesInfoDictionary[entityCaption].Objects;
        }
        public string TypeNameByEntityCaption(string entityCaption)
        {
            return _entitiesInfoDictionary[entityCaption].EntityTypeName;
        }
        public EntityInfo EntityInfoByEntityCaption(string entityCaption)
        {
            return _entitiesInfoDictionary[entityCaption];
        }

        //public Audience AudienceByKeyElements(decimal number, string nameTypeAudience)
        //{
        //    throw new NotImplementedException();
        //}

        //public AudienceEqipmentTypes AudienceEqipmentTypeByKeyEqlements(string nameTypeEqipment, string nameTypeAudience)
        //{
        //    throw new NotImplementedException();
        //}

        //public Eqipment EqipmentByKeyElements(DateTime date, string eqipmentNameType)
        //{
        //    throw new NotImplementedException();
        //}

        //public EqipmentType EqipmentTypeByKeyElements(decimal name, string eqipmentNameType)
        //{
        //    throw new NotImplementedException();
        //}

        //public EqipmentAudience EqipmentAudienceByKeyElements(int number1, string eqipmentNameType, double inventoryNumber)
        //{
        //    throw new NotImplementedException();
        //}






        //private readonly BindingList<Audience> _audiences =
        //    new BindingList<Audience>();
        //private readonly BindingList<AudienceEqipmentTypes> _audienceeqipmenttypes =
        //    new BindingList<AudienceEqipmentTypes>();
        //private readonly BindingList<AudienceType> _audiencetypes =
        //    new BindingList<AudienceType>();
        //private readonly BindingList<Eqipment> _eqipments =
        //    new BindingList<Eqipment>();
        //private readonly BindingList<EqipmentAudience> _eqipmentaudiences =
        //    new BindingList<EqipmentAudience>();
        //private readonly BindingList<EqipmentType> _eqipmenttypes =
        //    new BindingList<EqipmentType>();


        //public BindingList<Audience> Audiences
        //{
        //    get { return _audiences; }
        //}
        //public BindingList<AudienceEqipmentTypes> AudienceEqipmentTypess
        //{
        //    get { return _audienceeqipmenttypes; }
        //}
        //public BindingList<AudienceType> AudienceTypes
        //{
        //    get { return _audiencetypes; }
        //}
        //public BindingList<Eqipment> Eqipments
        //{
        //    get { return _eqipments; }
        //}
        //public BindingList<EqipmentAudience> EqipmentAudiences
        //{
        //    get { return _eqipmentaudiences; }
        //}
        //public BindingList<EqipmentType> EqipmentTypes
        //{
        //    get { return _eqipmenttypes; }
        //}
        //public void Clear()
        //{
        //    Audiences.Clear();
        //    AudienceEqipmentTypess.Clear();
        //    AudienceTypes.Clear();
        //    Eqipments.Clear();
        //    EqipmentAudiences.Clear();
        //    EqipmentTypes.Clear();
        //}
        //public Audience AudienceByKey(string key)
        //{
        //    //foreach (var obj in Audiences)
        //    //{
        //    //    if (obj.Key == key) return obj;
        //    //}
        //    //return null;
        //    return Audiences.FirstOrDefault(e => e.Key.Equals(key));
        //}
        //public AudienceEqipmentTypes AudienceEqipmentTypesByKey(string key)
        //{
        //    //foreach (var obj in AudienceEqipmentTypes)
        //    //{
        //    //    if (obj.Key == key) return obj;
        //    //}
        //    //return null;
        //    return AudienceEqipmentTypess.FirstOrDefault(e => e.Key.Equals(key));
        //}
        //public AudienceType AudienceTypeByKey(string key)
        //{
        //    //foreach (var obj in AudienceTypes)
        //    //{
        //    //    if (obj.Key == key) return obj;
        //    //}
        //    //return null;
        //    return AudienceTypes.FirstOrDefault(e => e.Key.Equals(key));
        //}
        //public Eqipment EqipmentByKey(string key)
        //{
        //    //    foreach (var obj in Eqipments)
        //    //    {
        //    //        if (obj.Key == key) return obj;
        //    //    }
        //    //    return null;
        //    return Eqipments.FirstOrDefault(e => e.Key.Equals(key));
        //}
        //public EqipmentAudience EqipmentAudienceByKey(string key)
        //{
        //    //foreach (var obj in EqipmentAudiences)
        //    //{
        //    //    if (obj.Key == key) return obj;
        //    //}
        //    //return null;
        //    return EqipmentAudiences.FirstOrDefault(e => e.Key.Equals(key));
        //}
        //public EqipmentType EqiomentTypeByKey(string key)
        //{
        //    //foreach (var obj in EqipmentTypes)
        //    //{
        //    //    if (obj.Key == key) return obj;
        //    //}
        //    //return null;
        //    return EqipmentTypes.FirstOrDefault(e => e.Key.Equals(key));
        //}
    }
}
