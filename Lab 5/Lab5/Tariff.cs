using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    public class Tariff
    {
        public string Title { get; set; }
        public int Price { get; set; }
        public Tariff(string t, int p)
        {
            Title = t;
            Price = p;
        }
    }
}
