using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab5;
namespace TestLab5
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Firm S = new Firm();
            S.AddTariff("tariff1", 1000);
            S.AddTariff("tariff2", 2000);
            S.AddCustomer("Misha", CustomerType.VIP);
            S.LogIn("Misha");
            S.BuyTariff("tariff1");
            S.BuyTariff("tariff2");
            S.LogOut();
            int expectedResult = 3000;
            int actualResault = S.GetCustByName("Misha").GetSum();
            Assert.AreEqual(expectedResult, actualResault);
        }
        [TestMethod]
        public void TestMethod2()
        {
            Firm S = new Firm();
            S.AddTariff("tariff1", 1000);
            S.AddTariff("tariff2", 2000);
            S.AddCustomer("Misha", CustomerType.VIP);
            S.AddCustomer("Lida", CustomerType.VIP);
            S.LogIn("Misha");
            S.BuyTariff("tariff1");
            S.BuyTariff("tariff2");
            S.LogOut();
            S.LogIn("Lida");
            S.BuyTariff("tariff1");
            S.LogOut();
            int expectedResult = 4000;
            int actualResault = S.GetTotalSum();
            Assert.AreEqual(expectedResult, actualResault);
        }
    }
}
