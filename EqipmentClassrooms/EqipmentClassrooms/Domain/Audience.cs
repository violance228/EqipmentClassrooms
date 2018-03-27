using Common.Entities;
using System;

namespace EqipmentClassrooms.Domain
{   [Serializable]
   public partial class Audience : Entity 
    {
        protected override void UpdateKey()
        {
            if (Name == null) return;
            Key = Name;
        }
        private string name;
        string _nameTypeAydience;
        uint? _number;
        public uint? Number { get { return _number; }
            set
            {
                if (value != null && value <= 0)
                {
                    throw new ArgumentOutOfRangeException(
                        "Значення аудиторії "
                        + "повинно бути додатним числом");
                }
                _number = value;
            }
        }
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
            get { return name; }
            set
            {
                name = value;
                UpdateKey();
            }
        }
        public Audience(string name, string nametypeaudience, uint number)
        {
            Name = name;
            NameTypeAudience = nametypeaudience;
            Number = number;
            
        }
        public Audience() { }
        public Audience Clone()
        {
            Audience other = (Audience)MemberwiseClone();
            return other;
        }
        public override string ToString()
        {
            return string.Format
                ("Назва: {0} №{1}, Тип - {2} Примітка: {3}\t", 
                Name,
                Number.HasValue? Number.Value.ToString() : "(не вказано)",
                !string.IsNullOrWhiteSpace(NameTypeAudience) ? NameTypeAudience : "(не вказано)",
                Note
                );
        }
        public Audience Copy()
        {
            Audience other = (Audience)MemberwiseClone();
            return other;
        }
    }
}
