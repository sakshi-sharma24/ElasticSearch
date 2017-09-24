using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ElasticSearchSolution;
using System.Linq;

namespace TestCases
{
    [TestClass]
    public class ElasticSearchTestCases
    {
        [TestClass]
        public class ElasticSearchTest
        {
            [TestMethod]
            public void AddNewIndexTest()
            {
                ElasticSearch objSearch = new ElasticSearch();

                objSearch.AddNewIndex(new Hotel(1, "taj", "India"));
                objSearch.AddNewIndex(new Hotel(2, "hyatt", "India"));
                objSearch.AddNewIndex(new Hotel(3, "pancham", "India"));
                objSearch.AddNewIndex(new Hotel(4, "paradise", "India"));
                objSearch.AddNewIndex(new Hotel(4, "ibsis", "India"));
                objSearch.AddNewIndex(new Hotel(4, "xyzs", "India"));
            }


            [TestMethod]
            public void GetResultTest()
            {
                ElasticSearch objSearch = new ElasticSearch();
                var result = objSearch.GetResult();
                Assert.IsTrue(result.FirstOrDefault<Hotel>(x => x.Country == "India") != null);
                Assert.IsTrue(result.FirstOrDefault<Hotel>(x => x.Country == "India") != null);
                Assert.IsTrue(result.FirstOrDefault<Hotel>(x => x.Country == "India") != null);
            }
        }
    }
}
