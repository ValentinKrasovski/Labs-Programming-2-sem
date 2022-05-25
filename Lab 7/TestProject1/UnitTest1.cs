using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab7;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Matrix m1 = new Matrix();
            bool check = m1 == 0;
            Assert.AreEqual(true, check);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Matrix m2 = new Matrix(2,4);
            int check = (int)m2;
            Assert.AreEqual(8, check);
        }
        [TestMethod]
        public void TestMethod3()
        {        
            Matrix m1 = new Matrix(2,2);
            Matrix m2 = m1 * 7;
            Assert.AreEqual(14, m2[1,1]);
        }
    }
}
