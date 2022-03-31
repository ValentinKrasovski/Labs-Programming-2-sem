using System;
using Task1;
namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int x = Convert.ToInt32(Console.ReadLine());
            x = Class1.Change(x);
            Console.WriteLine("Полученный результат: " + x);
        }
    }
}
