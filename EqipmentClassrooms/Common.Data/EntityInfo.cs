using Common.Entities.Extensions;
using Common.Extensions;
using Common.Interfaces;
using System;
using System.Collections.Generic;

namespace Common.Data
{

    public class EntityInfo
    {
        public string EntityCaption { get; set; }
        public string EntityTypeName { get; set; }
        public IEnumerable<IEntity> Objects { get; set; }

        public override string ToString()
        {
            return string.Format("Сутність \"{0}\", тип: {1};\n",
                EntityCaption, EntityTypeName);
        }

        public string ToKeysString()
        {
            return this.Objects.ToKeysString(
                string.Format("Сутність \"{0}\", тип: {1}",
                EntityCaption, EntityTypeName));
        }
    }
}
