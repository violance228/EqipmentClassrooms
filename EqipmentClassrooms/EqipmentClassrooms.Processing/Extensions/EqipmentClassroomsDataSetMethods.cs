//using Common.Entities.Extensions;
//using Common.Extensions;
//using EqipmentClassrooms.Interfaces;
//using EqipmentClassrooms.Domain;
//using System;
//using System.Collections.Generic;

//namespace EqipmentClassrooms.Processing.Extensions
//{
//    public static class EqipmentClassroomsDataSetMethods
//    {
//        public static string ToKeysString(this IEqipmentClassroomsDataSet dataSet)
//        {
//            return string.Concat(
//                dataSet.Audiencess.ToKeysString(),
//                dataSet.AudienceEqipmentTypes.ToKeysString(),
//                dataSet.AudienceTypess.ToKeysString(),
//                dataSet.Eqipmentss.ToKeysString(),
//                dataSet.EqipmentAudiencess.ToKeysString(),
//                dataSet.EqipmentTypess.ToKeysString()
//                );
//        }
//        public static void WriteKeysToConsole(this IEqipmentClassroomsDataSet dataSet)
//        {
//            Console.WriteLine(ToKeysString(dataSet));
//        }

//        public static IEnumerable<Audience> GetCountriesWithSpecifiedPopulation(
//            this IEqipmentClassroomsDataSet dataSet)
//        {
//            return dataSet.Audiencess
//                .GetCountriesWithSpecifiedPopulation(dataSet.Populations);
//        }
//        public static IEnumerable<Audience> GetCountriesWithNotSpecifiedPopulation(
//           this IEqipmentClassroomsDataSet dataSet)
//        {
//            return dataSet.Audiences
//                .GetCountriesWithNotSpecifiedPopulation(dataSet.Populations);
//        }
//    }
//}
