using Common.Entities;
using System;

namespace EqipmentClassrooms.Domain
{[Serializable]
    public partial class EqipmentAudience : Entity
    {
        protected override void UpdateKey()
        {
            if (Name == null) return;
            Key = Name;
        }
        
        string _name;
        public double? InventoryNumber { get; set; }
        public uint? Number1 { get; set; }
        string _eqipmentNameType;
        public string EqipmentNameType
        {
            get { return _eqipmentNameType; }
            set
            {
                if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва типу не мoже бути пуста");
                _eqipmentNameType = value;
            }
        }
        public string Note { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {   if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Назва імені не може бути пуста");
                _name = value;
                UpdateKey();
            }
        }
        public EqipmentAudience(string name, string eqipmentnametype)
        {
            Name = name;

            EqipmentNameType = eqipmentnametype;
        }
        public EqipmentAudience() { }
        public EqipmentAudience Clone()
        {
            EqipmentAudience other = (EqipmentAudience)MemberwiseClone();
            return other;
        }
        public override string ToString()
        {
            return string.Format
                ("Назва: {0},  Інвентарний номер: - {1} Номер: {2},Назва типу обладнання:{3}, Примітка-{4}",
                Name,
                InventoryNumber.HasValue ? InventoryNumber.Value.ToString() : "(не вказано)",
                Number1.HasValue ? Number1.Value.ToString() : "(не вказано)",
                !string.IsNullOrWhiteSpace(EqipmentNameType) ? EqipmentNameType : "(не вказано)",
                !string.IsNullOrWhiteSpace(Note) ? Note : "(не вказано)"
                );
        }
        public EqipmentAudience Copy()
        {
            EqipmentAudience other = (EqipmentAudience)MemberwiseClone();
            return other;
        }
    }
}
