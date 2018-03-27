using Common.Interfaces;
using System;

namespace Common.Entities {

    public abstract partial class Entity : IEntity {

        public int? Id { get; set; }

        private string _key;

        public virtual string Key {
            get { 
                if(string.IsNullOrEmpty(_key)) {
                    UpdateKey();
                }
                return _key; 
            }
            protected set { _key = value; }
        }

        protected abstract void UpdateKey();

        public override string ToString() {
            return Key;
        }

    }
}
