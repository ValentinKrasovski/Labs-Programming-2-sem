using System;
using Task3;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите дату: ");
            string date = Console.ReadLine();
            int day = Convert.ToInt32(date.Substring(0, 2));
            int month = Convert.ToInt32(date.Substring(3, 2));
            int year = Convert.ToInt32(date.Substring(6, 4));
            Console.WriteLine("День недели данной даты: " + DateService.GetDay(date));
           
            Console.WriteLine("Разница между датами (в днях): " + DateService.GetDaysSpan(day, month, year));

        }
    }
}
