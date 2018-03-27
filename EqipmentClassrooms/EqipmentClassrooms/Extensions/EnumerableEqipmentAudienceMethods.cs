using System.Collections.Generic;
using System.Linq;
using EqipmentClassrooms.Domain;

namespace CountriesArea.Extensions
{
    public static class EnumerableEqipmentAudienceMethods
    {

        public static IEnumerable<string> UsedGeographicalRegionNames(
            this IEnumerable<Audience> collection)
        {
            return collection.Select(e => e.GeographicalRegionName)
                .Distinct().OrderBy(e => e);
        }

        public static IEnumerable<Audience> GetCountriesWithSpecifiedPopulation(
            this IEnumerable<Audience> countries, IEnumerable<Population> populations)
        {
            string[] countriesNames = populations.UsedCountryNames().ToArray();
            return countries.Where(e => countriesNames.Contains(e.Name))
                .OrderBy(e => e);
        }

        public static IEnumerable<Audience> GetCountriesWithNotSpecifiedPopulation(
            this IEnumerable<Audience> audiences, IEnumerable<Eqipment> populations)
        {
            return audiences
                .Except(audiences.GetCountriesWithSpecifiedPopulation(populations))
                .OrderBy(e => e);
        }

    }
}
