using Common.Entities.Extensions;
using Common.Extensions;
using System.Text;


namespace EqipmentClassrooms.Data
{
    partial class EqipmentClassroomsDataSet
    {
        public override string ToString()
        {
            return ToString(string.Format("Об'єкти ПО\"{0}\"", SubjectAreaName));
        }
        public string ToString(string promt)
        {
            StringBuilder sb = new StringBuilder(4096);
            sb.AppendFormat("{0}:\n\n", promt);
            sb.Append(Audiencess.ToObjectsString(
                "Аудиторії"));
            sb.Append(AudienceEqipmentTypes.ToObjectsString(
                "Типи аудиторій та обладнання"));
            sb.Append(AudienceTypess.ToObjectsString(
                "Типи аудиторій"));
            sb.Append(Eqipmentss.ToObjectsString(
                "Обладнання"));
            sb.Append(EqipmentAudiencess.ToObjectsString(
                "Обладнання аудиторій"));
            sb.Append(EqipmentTypess.ToObjectsString(
                "Типи обладнань"));
            return sb.ToString();
        }
        public string ToKeysString()
        {
            return ToKeysString(string.Format(
                "Ключі об'єктів ПО \"{0}\"",
                SubjectAreaName));
        }

        public string ToKeysString(string prompt)
        {
            string s = string.Format("{0}:\n", prompt);
            s += Audiencess.ToKeysString("Аудиорії");
            s += AudienceEqipmentTypes.ToKeysString("Типи аудиторій та обладнання");
            s += AudienceTypess.ToKeysString("Типи аудиторій");
            s += Eqipmentss.ToKeysString("Обладнання");
            s += EqipmentAudiencess.ToKeysString("Обладнання аудиторій");
            s += EqipmentTypess.ToKeysString("Типи Обладнання");
            return s;
        }
    }
}
       
