using EqipmentClassrooms.Domain;
using System.Collections.Generic;
using System.Linq;

namespace EqipmentClassrooms.Extensions
{
    public static class EqipmentAudienceMethods
    {
        public static IEnumerable<Eqipment> GetEqipments(
            this EqipmentAudience eqipmentNameType, IEnumerable<Eqipment> eqipments)
        {
            return eqipments
                .Where(e => e.EqipmetNameTypeName == eqipmentNameType.Name);
        }
    }
}

