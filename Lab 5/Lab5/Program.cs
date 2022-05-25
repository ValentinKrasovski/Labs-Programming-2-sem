using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm S = new Firm();
            S.AddTariff("tariff1", 1000);
            S.AddTariff("tariff2", 2000);
            S.AddTariff("tariff3", 3000);
            S.AddCustomer("Sasha", CustomerType.VIP);
            S.AddCustomer("Lika", CustomerType.usual);
            S.LogIn("Lika");
            S.BuyTariff("tariff2");
            S.BuyTariff("tariff3");
            S.LogOut();
            S.LogIn("Sasha");
            S.BuyTariff("tariff1");
            S.LogOut();
            Console.WriteLine(S.GetTotalSum());
            Console.WriteLine(S.GetTariffsByCust("Lika"));
        }
    }
}
