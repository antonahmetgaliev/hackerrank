using T1ArrayRate;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T1ArrayRateTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void CompareTripletsTestBobWin()
        {
            var actual = Solution.CompareTriplets(new List<int> {2, 4, 5}, new List<int> {3, 4, 6});
            var expectation = new List<int> {0, 2};
            CollectionAssert.AreEqual(expectation, actual);
        }

        [TestMethod]
        public void CompareTripletsTestAliceWin()
        {
            var actual = Solution.CompareTriplets(new List<int> {4, 4, 7}, new List<int> {3, 4, 6});
            var expectation = new List<int> {2, 0};
            CollectionAssert.AreEqual(expectation, actual);
        }

        [TestMethod]
        public void CompareTripletsTestDraw()
        {
            var actual = Solution.CompareTriplets(new List<int> {4, 4, 4}, new List<int> {4, 4, 4});
            var expectation = new List<int> {0, 0};
            CollectionAssert.AreEqual(expectation, actual);
        }
    }
}
