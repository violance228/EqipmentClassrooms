using System;
using Common.Entities;

namespace EqipmentClassrooms.Domain
{[Serializable]
    public partial class Eqipment : Entity
    {
        protected override void UpdateKey()
        {
            if (Name == null || !Date.HasValue)
                return;
            Key = string.Format("{0}, {1}",
                Name, Date.Value.ToString("yyyy"));
        }

        DateTime? _date;
        public DateTime? date
        {
            get { return _date; }
            set
            {
                if (value.HasValue && value > DateTime.Now)
                {
                    throw new ArgumentOutOfRangeException(
                        "Дата " + value + " ще не наступила");
                }
                _date = value;
                UpdateKey();
            }
        }
        string _name;

        public string EqipmentNameType { get; set; }
        
        public string Description { get; set; }
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
        public DateTime? Date
        {
            get { return date; }
            set
            {
                if (value.HasValue && value.Value <= DateTime.Now)
                {
                    date = value;
                }

                UpdateKey();
            }
        }

        public Eqipment(string Name, DateTime date, string eqnt, string description)
        {
            Date = date;
            this.Name = Name;
            EqipmentNameType = eqnt;
            Description = description;
        }

        public Eqipment()
        {
        }

        public override string ToString()
        {
            return string.Format("Назва: {0},  Назва типу обладнання: - {1}, Примітка-{2}, Дата: {3}",
                Name,
                !string.IsNullOrWhiteSpace(EqipmentNameType) ? EqipmentNameType : "(не вказано)",
                !string.IsNullOrWhiteSpace(Description) ? Description : "(не вказано)",
                date.HasValue ? date.Value.ToShortDateString() : "(не вказано)");
        }
        public Eqipment Copy()
        {
            Eqipment other = (Eqipment)MemberwiseClone();
            return other;
        }
    }
}
