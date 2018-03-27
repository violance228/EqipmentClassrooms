using Common.Data;

namespace EqipmentClassrooms.Data
{
    partial class EqipmentClassroomsDataSet
    {
        protected void CreateEntitiesInfo()
        {
            EntityInfo entityInfo;

            entityInfo = new EntityInfo()
            {
                EntityTypeName = "Audience",
                EntityCaption = "Аудиторія",
                Objects = Audiencess
            };
            _entitiesInfoDictionary.Add(entityInfo.EntityCaption, entityInfo);

            entityInfo = new EntityInfo()
            {
                EntityTypeName = "AudienceEqipmentTypes",
                EntityCaption = "Аудиторії та типи обладнання",
                Objects = AudienceEqipmentTypes
            };
            _entitiesInfoDictionary.Add(entityInfo.EntityCaption, entityInfo);
            entityInfo = new EntityInfo()
            {
                EntityTypeName = "AudienceType",
                EntityCaption = "Типи аудиторій",
                Objects = AudienceTypess
            };
            _entitiesInfoDictionary.Add(entityInfo.EntityCaption, entityInfo);
            entityInfo = new EntityInfo()
            {
                EntityTypeName = "Eqipment",
                EntityCaption = "Обладнання",
                Objects = Eqipmentss
            };
            _entitiesInfoDictionary.Add(entityInfo.EntityCaption, entityInfo);
            entityInfo = new EntityInfo()
            {
                EntityTypeName = "EqipmentAudience",
                EntityCaption = "Обладнання аудиторій",
                Objects = EqipmentAudiencess
            };
            _entitiesInfoDictionary.Add(entityInfo.EntityCaption, entityInfo);
            entityInfo = new EntityInfo()
            {
                EntityTypeName = "EqipmentType",
                EntityCaption = "Типи обладнання",
                Objects = EqipmentTypess
            };
            _entitiesInfoDictionary.Add(entityInfo.EntityCaption, entityInfo);

        }
    }
        
}
