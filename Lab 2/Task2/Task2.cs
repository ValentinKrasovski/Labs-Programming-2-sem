using System;

namespace Task2
{
        public class task2
    {
        public static int Location(int x, int y)
        {
            if(x<40 && x>-40 && y<40 && y > -40)
            {              
                return 1;
            }
            if((x==40 && y <= 40 && y >= -40)||(x == -40 && y <= 40 && y >= -40)||(y == 40 && x <= 40 && x >= -40) || (y == -40 && x <= 40 && x >= -40))
            {              
                return 2;
            }
            else
            {
                return 3;
            }


        }
        static void Main(string[] args)
        {
            int posit = 1;
            while (posit == 1)
            {
                Console.WriteLine("Введите координату по X: ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите координату по Y: ");
                int y = Convert.ToInt32(Console.ReadLine());
                int check = Location(x, y);
                switch (check)
                {
                    case 1:
                        Console.WriteLine("Нет");
                        break;
                    case 2:
                        Console.WriteLine("На границе");
                        break;
                    default:
                        Console.WriteLine("Да");
                        break;

                }
                Console.WriteLine("\nВведите 1, если хотите продолжить. ");
                Console.WriteLine("Введите другое число, если хотите завершить программу. ");
                posit = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
}
