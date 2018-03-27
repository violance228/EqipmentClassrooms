using Common.Interfaces;
using System.Collections.Generic;

namespace Common.Data.Interfaces
{

    public interface IEntitiesInfoAccessible
    {
        IEnumerable<string> EntityCaptions { get; }

        IEnumerable<EntityInfo> EntitiesInfo { get; }

        IEnumerable<IEntity> ObjectsByEntityCaption(string entityCaption);

        string TypeNameByEntityCaption(string entityCaption);

        EntityInfo EntityInfoByEntityCaption(string entityCaption);
    }
}
