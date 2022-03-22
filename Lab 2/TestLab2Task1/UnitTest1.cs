using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace TestLab2Task1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(5, task1.MyFunc(34));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(4, task1.MyFunc(36));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(3, task1.MyFunc(234));
        }

    }
}
