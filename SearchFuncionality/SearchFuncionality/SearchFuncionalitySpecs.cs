using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
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

        [Test]
        public void return_cities_that_its_name_starts_like_search_string_case_sensitive() {
            const string searchString = "va";

            var foundCities = SearchFuncionality.Run(searchString);

            Assert.AreEqual(0, foundCities.Count);
        }

        [Test]
        public void return_cities_that_its_name_contains_search_string() {
            const string searchString = "ape";

            var foundCities = SearchFuncionality.Run(searchString);

            Assert.AreEqual(1, foundCities.Count);
            Assert.AreEqual("Budapest", foundCities[0]);
        }

        [Test]
        public void return_all_cities_when_search_string_is_asterisk() {
            const string searchString = "*";

            var foundCities = SearchFuncionality.Run(searchString);

            Assert.AreEqual(16, foundCities.Count);
            Assert.AreEqual("Paris", foundCities[0]);
            Assert.AreEqual("Budapest", foundCities[1]);
            Assert.AreEqual("Skopje", foundCities[2]);
            Assert.AreEqual("Rotterdam", foundCities[3]);
            Assert.AreEqual("Valencia", foundCities[4]);
            Assert.AreEqual("Vancouver", foundCities[5]);
            Assert.AreEqual("Amsterdam", foundCities[6]);
            Assert.AreEqual("Vienna", foundCities[7]);
            Assert.AreEqual("Sydney", foundCities[8]);
            Assert.AreEqual("New York City", foundCities[9]);
            Assert.AreEqual("London", foundCities[10]);
            Assert.AreEqual("Bangkok", foundCities[11]);
            Assert.AreEqual("Hong Kong", foundCities[12]);
            Assert.AreEqual("Dubai", foundCities[13]);
            Assert.AreEqual("Rome", foundCities[14]);
            Assert.AreEqual("Istanbul", foundCities[15]);
        }
    }

    public class SearchFuncionality {
        private static readonly List<string> Cities = new List<string> {
            "Paris", 
            "Budapest", 
            "Skopje", 
            "Rotterdam", 
            "Valencia", 
            "Vancouver",
            "Amsterdam",
            "Vienna",
            "Sydney",
            "New York City",
            "London",
            "Bangkok",
            "Hong Kong",
            "Dubai",
            "Rome",
            "Istanbul"
        };

        public static List<string> Run(string searchString) {
            if (searchString == "*") return Cities;
            if (searchString.Length < 2) return new List<string>();
            return Cities.FindAll(x => x.Contains(searchString));
        }
    }
}