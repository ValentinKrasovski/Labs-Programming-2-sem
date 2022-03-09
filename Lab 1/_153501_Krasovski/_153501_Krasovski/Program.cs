using System;

namespace _153501_Krasovski
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.WriteLine("Enter the first number: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the second number: ");
            b = Convert.ToDouble(Console.ReadLine());
            c = a / b;
            Console.WriteLine("The result: " + c);
        }
    }
}
