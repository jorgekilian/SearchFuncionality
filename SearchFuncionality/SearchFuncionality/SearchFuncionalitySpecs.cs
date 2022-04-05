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
    }

    public class SearchFuncionality {
        public static List<string> Run(string searchString) {
            return new List<string>();
        }
    }
}