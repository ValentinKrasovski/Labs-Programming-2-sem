using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task1;

namespace TestTask1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(18, Class1.Change(36));
        }
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(10, Class1.Change(20));
        }
        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(0, Class1.Change(9));
        }
        [TestMethod]
        public void TestMethod4()
        {
            Assert.AreEqual(0, Class1.Change(7));
        }
        
    }
}
