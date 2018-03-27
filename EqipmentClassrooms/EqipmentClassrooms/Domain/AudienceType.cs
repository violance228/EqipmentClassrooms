using System;
using Common.Entities;

namespace EqipmentClassrooms.Domain
{[Serializable]
    public class AudienceType : Entity
    {
        protected override void UpdateKey()
        {
            if (Name == null) return;
            Key = Name;
        }
      
        string _name;
        string _nameTypeAydience;

        public string Definition { get; set; }
        public string NameTypeAudience
        {
            get { return _nameTypeAydience; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва типу не мoже бути пуста");
                _nameTypeAydience = value;
            }
        }
        public string Note { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва імені не може бути пуста");
                _name = value;
                UpdateKey();
            }
        }
        public AudienceType(string name)
        {
            Name = name;
            
        }
        public AudienceType() { }
        public AudienceType Clone()
        {
            AudienceType other = (AudienceType)MemberwiseClone();
            return other;
        }
        public override string ToString()
        {
            return string.Format("Назва: {0}, Визначення - {1} Назва типу аудиторії: {2}, Примітка-{3}",
                Name,
                !string.IsNullOrWhiteSpace(Definition) ? Definition : "(не вказано)",
                !string.IsNullOrWhiteSpace(NameTypeAudience) ? NameTypeAudience : "(не вказано)",
                !string.IsNullOrWhiteSpace(Note) ? Note : "(не вказано)");
        }
        public AudienceType Copy()
        {
            AudienceType other = (AudienceType)MemberwiseClone();
            return other;
        }
    }
}
