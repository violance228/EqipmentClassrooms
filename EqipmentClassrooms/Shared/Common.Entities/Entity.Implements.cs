using Common.Interfaces;
using System;

namespace Common.Entities {

    partial class Entity : IComparable, IComparable<IEntity>, IEquatable<IEntity> {

        public int CompareTo(object obj) {
            if (obj == null) return 1;
            if (!(obj is IEntity)) {
                throw new ArgumentException(
                    "Об'єкт порівняння не є екземпляром сутності");
            }
            return this.CompareTo((IEntity)obj);
        }

        public int CompareTo(IEntity other) {
            if (other == null) return 1;
            return string.Compare(Key, other.Key, StringComparison.Ordinal);
        }

        public bool Equals(IEntity other) {
            if ((object)other == null)
                return false;
            if (GetType() != other.GetType())
                return false;
            if (Key == null)
                return false;
            return Key.Equals(other.Key);
        }

        public override bool Equals(object obj) {
            return Equals(obj as IEntity);
        }

        public override int GetHashCode() {
            return Key.GetHashCode();
        }

    }
}

