using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task3;
namespace TestTask3
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, DateService.GetDaysSpan(26,03,2022));
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(3, DateService.GetDaysSpan(28,03,2022));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(1, DateService.GetDaysSpan(30,03,2022));
        }

        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(2, DateService.GetDaysSpan(29, 03, 2022));
        }

       
    }
}
