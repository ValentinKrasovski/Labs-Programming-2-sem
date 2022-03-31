using System;

namespace Task1
{
    public class task1
    {

       public static int MyFunc(int b)
        {
            if (b > 99 || b<10)
            {   
                return 3;
            }

            if ((b / 10 + b % 10) % 3 == 0)
            {               
                return 4;
            }
            else
            {                
                return 5;
            }
           
        }



        static void Main(string[] args)
        {
            int posit = 1;
            while (posit==1)
            {
                Console.WriteLine("Введите двузначное число: ");
                int b = Convert.ToInt32(Console.ReadLine());
                int check = MyFunc(b);
                switch (check)
                {
                    case 4:
                        Console.WriteLine("Сумма цифр двузначного числа кратна трем!!!");
                        break;
                    case 5:
                        Console.WriteLine("Сумма цифр двузначного числа не кратна трем!!!");
                        break;
                    default:
                        Console.WriteLine("Ваше число не двузначное!");
                        break;

                }
                Console.WriteLine("\nВведите 1, если хотите продолжить ");
                Console.WriteLine("Введите другое число, если хотите завершить программу ");
                posit = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
