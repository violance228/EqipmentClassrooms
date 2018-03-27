using Common.Interfaces;
using System;

namespace Common.Events
{
    public class EntityEventArgs : EventArgs
    {

        public readonly IEntity entityObject;

        public EntityEventArgs(IEntity entityObject)
        {
            this.entityObject = entityObject;
        }
    }
}
