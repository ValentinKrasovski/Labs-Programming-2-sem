using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2;
namespace TestLab2Task2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(1, task2.Location(0,10));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, task2.Location(40, 10));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(3, task2.Location(50, 10));
        }
    }
}
