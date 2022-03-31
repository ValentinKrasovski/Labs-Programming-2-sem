using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Services
{
    public class Class2
    {
        public static double Calculate(double z, double b)
        {
            if (z < 1)
            {
                Console.WriteLine("Ветка: z < 1");
                return z / b;
            }
            else
            {
                Console.WriteLine("Ветка: z >= 1");
                return Math.Sqrt(Math.Pow(z * b, 3));
            }
        }
    }
}
