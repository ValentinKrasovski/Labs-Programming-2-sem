using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public enum CustomerType
    {
        VIP,
        usual
    }
    public class Customer
    {
        List<Tariff> listTarOfCust = new List<Tariff>();
        public string Name { get; set; }
        public List<Tariff> ListTarOfCust
        {
            get { return listTarOfCust; }
        }
        public CustomerType CType { get; set; }
        public Customer(string n, CustomerType ct)
        {
            Name = n;
            CType = ct;
        }
        public void BuyTariff(Tariff t)
        {

            listTarOfCust.Add(t);

        }
        public int GetSum()
        {
            int sum = 0;
            foreach (Tariff item in ListTarOfCust)
            {
                sum += item.Price;
            }
            return sum;
        }
    }


}
