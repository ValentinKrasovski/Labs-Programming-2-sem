using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Services;
namespace TestTask2
{
    [TestClass]
    public class UnitTest1
    {
            [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(0, Class2.Calculate(0,1));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(0.5, Class2.Calculate(0.5, 1));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(8, Class2.Calculate(4, 1));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(8, Class2.Calculate(2, 2));
        }
    }
}
