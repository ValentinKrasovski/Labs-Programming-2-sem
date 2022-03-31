using System;
using Task2.Services;
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите число z: ");
            double z = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double x = Class2.Calculate(z, b);
            double y = -Math.PI + Math.Pow(Math.Cos(x * x * x), 2) + Math.Pow(Math.Sin(x * x), 3);
            Console.WriteLine("Полученный результат: y = " + y);
        }
    }
}
