using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_4;
namespace TestLab4
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Tariff tariff = new Tariff();
            tariff.ChangeTariffSizeUp(10);
            Assert.AreEqual(10, tariff.TariffSize);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Tariff tariff = new Tariff();
            tariff.TariffSize = 50;
            tariff.ChangeTariffSizeDown(10);
            Assert.AreEqual(40, tariff.TariffSize);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Firm firm = Firm.getInstance("ОАО Белаз");
            Assert.AreEqual("ОАО Белаз",firm.Name);
        }
    }
}
