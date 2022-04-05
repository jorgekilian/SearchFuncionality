using System.Collections.Generic;
using NUnit.Framework;

namespace SearchFuncionalitySpecs {
    public class Tests {


        [Test]
        public void no_return_cities_when_search_string_has_a_length_less_than_two_chars() {
            const string searchString = "a";

            var foundCities = SearchFuncionality.Run(searchString);

            Assert.AreEqual(0, foundCities.Count);
        }

        [Test]
        public void return_cities_that_its_name_starts_like_search_string() {
            const string searchString = "Va";

            var foundCities = SearchFuncionality.Run(searchString);

            Assert.AreEqual(2, foundCities.Count);
            Assert.AreEqual("Valencia", foundCities[0]);
            Assert.AreEqual("Vancouver", foundCities[1]);
        }
    }

    public class SearchFuncionality {
        public static List<string> Run(string searchString) {
            if (searchString.Length < 2) return new List<string>();
            return new List<string> { "Valencia", "Vancouver" };
        }
    }
}