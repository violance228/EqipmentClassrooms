using System;
using Common.Entities;

namespace EqipmentClassrooms.Domain
{[Serializable]
    public partial class EqipmentType : Entity
    {
        protected override void UpdateKey()
        {
            if (Name == null) return;
            Key = Name;
        }
        
        public string Definition { get; set; }
       
        string _eqipmentNameType;
        string _name;

        public string EqipmentNameType
        {
                get { return _eqipmentNameType; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва типу не мже бути пуста");
                    _eqipmentNameType = value;
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
        public EqipmentType(string name, string definition, string eqipmentnametype)
        {
            Name = name;
            Definition = definition;
            EqipmentNameType = eqipmentnametype;
        }

        public EqipmentType()
        {
        }

        public EqipmentType Clone()
        {
            EqipmentType other = (EqipmentType)MemberwiseClone();
            return other;
        }
        public override string ToString()
        {
            return string.Format("Назва: {0},  Визначення: - {1} Назва типу обладнання: {2}, Примітка-{3}",
                Name,
                !string.IsNullOrWhiteSpace(Definition) ? Definition : "(не вказано)",
                !string.IsNullOrWhiteSpace(EqipmentNameType) ? EqipmentNameType : "(не вказано)",
                !string.IsNullOrWhiteSpace(Note) ? Note : "(не вказано)");
        }
        public EqipmentType Copy()
        {
            EqipmentType other = (EqipmentType)MemberwiseClone();
            return other;
        }
    }
}
