using T2VeryBigSum;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace T2VeryBigSumTests
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void AVeryBigSumTest()
        {
            var actual = Solution.AVeryBigSum(new long[]{100001, 100002, 100003});
            Assert.AreEqual(300006,actual);
        }
    }
}
