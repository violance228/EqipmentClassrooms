using Common.Entities;
using System;

namespace EqipmentClassrooms.Domain
{[Serializable]
    public class AudienceEqipmentTypes : Entity
    {
        protected override void UpdateKey()
        {
            if (Name == null) return;
            Key = Name;
        } 
        string _name;
        string _nameTypeEqipment;
        string _nameTypeAydience;

        public string NameTypeAudience { 
                get { return _nameTypeAydience; }
                set { 
            
                    if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва типу не мoже бути пуста");
                    _nameTypeAydience = value;
                }
            
        }
        public string NameTypeEqipment
        {
            get { return _nameTypeEqipment; }
            set
            {

                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва типу не мoже бути пуста");
                _nameTypeEqipment = value;
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
        public AudienceEqipmentTypes(string name,string nametypeeqipment,string nametypeaudience)
        {
            Name = name;
            NameTypeAudience = nametypeaudience;
            NameTypeEqipment = nametypeeqipment;
        }
        public AudienceEqipmentTypes() { }
        public AudienceEqipmentTypes Clone()
        {
            AudienceEqipmentTypes other = (AudienceEqipmentTypes)MemberwiseClone();
            return other;
        }
        public override string ToString()
        {
            return string.Format("Назва: {0}, Назва типу аудиторії - {1} Назва типу обладнання: {2}, Примітка-{3}\t",
               Name,
               !string.IsNullOrWhiteSpace(NameTypeAudience) ? NameTypeAudience : "(не вказано)",
               !string.IsNullOrWhiteSpace(NameTypeEqipment) ? NameTypeEqipment : "(не вказано)",
               !string.IsNullOrWhiteSpace(Note) ? Note : "(не вказано)");
        }
        public AudienceEqipmentTypes Copy()
        {
            AudienceEqipmentTypes other = (AudienceEqipmentTypes)MemberwiseClone();
            return other;
        }
    }
}
