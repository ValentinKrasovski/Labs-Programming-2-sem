using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Firm
    {
        List<Tariff> listTariff = new List<Tariff>();
        List<Customer> listCust = new List<Customer>();
        Customer currentCust;
        public void AddTariff(string title, int pr)
        {
            listTariff.Add(new Tariff(title, pr));
        }
        public void AddCustomer(string name, CustomerType type)
        {
            listCust.Add(new Customer(name, type));
        }
        public Customer GetCustByName(string name)
        {
            for (int i = 0; i < listCust.Count; i++)
            {
                if (listCust[i].Name == name) return listCust[i];
            }

            return null;
        }
        public Tariff GetTariffByName(string name)
        {
            for (int i = 0; i < listTariff.Count; i++)
            {
                if (listTariff[i].Title == name) return listTariff[i];
            }

            return null;
        }
        public void LogIn(string n)
        {
            if (currentCust == null)
            {
                currentCust = GetCustByName(n);
            }
        }
        public void LogOut()
        {
            currentCust = null;
        }
        public int GetTotalSum()
        {
            int sum = 0;
            foreach (Customer c in listCust)
            {
                foreach (Tariff t in c.ListTarOfCust)
                {
                    sum += t.Price;
                }
            }
            return sum;
        }
        public void BuyTariff(string title)
        {
            Tariff t = GetTariffByName(title);
            currentCust.BuyTariff(t);
        }
        public string GetTariffsByCust(string name)
        {
            Customer c = GetCustByName(name);
            string str = "Customer:" + c.Name + "\n";
            foreach (Tariff t in c.ListTarOfCust)
            {
                str += t.Title + ":" + t.Price + "\n";
            }
            return str;
        }

    }
}
