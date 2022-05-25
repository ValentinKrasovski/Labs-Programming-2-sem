using System;

namespace Lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix();
            Matrix m2 = new Matrix(3);
            Console.WriteLine($"Maтрица m1\n {m1.ToString()}");          
            Console.WriteLine($"Матрица m2\n {m2.ToString()}");
            Console.WriteLine($"Operator +\n {(m1+m2).ToString()}");
            Console.WriteLine($"Operator -\n {(m1 - m2).ToString()}");
            Console.WriteLine($"Operator *5\n {(m1*5).ToString()}");
            Console.WriteLine($"Operator *\n {(m1 * m2).ToString()}");
            Console.WriteLine($"Operator ++\n {(++m1).ToString()}");
            Console.WriteLine($"Operator --\n {(--m2).ToString()}");
            Console.WriteLine($"Operator m1==m2\n {m1==m2}");
            Console.WriteLine($"Operator m1!=m2\n {m1 != m2}");
            Console.WriteLine($"Преобразование типов m1 в int \n {(int)m1}");
            Console.WriteLine($"Преобразование типов int в Matrix\n {(Matrix)m1}");
        }
    }
}
