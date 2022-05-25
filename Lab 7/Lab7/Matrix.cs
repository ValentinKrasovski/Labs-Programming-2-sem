using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    public class Matrix
    {
        int[,] matrix = { { 1, 2 }, { 4, 5 } };

        public int this[int i, int j]
        {
            get
            {
                if (i >= 0 && i < 2 && j >= 0 && j < 2)
                {
                    return matrix[i, j];
                }
                else throw new ArgumentOutOfRangeException(); 

            }
            set
            {
                if (i >= 0 && i < 2 && j >= 0 && j < 2)
                {
                    matrix[i, j] = value;
                }
            }
        }
        public Matrix(int a = 1)
        {
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    matrix[i, j] = a;
                }
            }
        }
        public Matrix(int a, int b)
        {
            matrix[0, 0] = a;
            matrix[0, 1] = 0;
            matrix[1, 0] = 0;
            matrix[1, 1] = b;
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m3 = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m3[i, j] = m1[i, j] + m2[i, j];
                }
            }
            return m3;
        }
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix m3 = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m3[i, j] = m1[i, j] - m2[i, j];
                }
            }
            return m3;
        }
        public static Matrix operator ++(Matrix m1)
        {
            Matrix m2 = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m2[i, j] = m1[i, j] + 10;
                }
            }
            return m2;
        }
        public static Matrix operator --(Matrix m1)
        {
            Matrix m2 = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m2[i, j] = m1[i, j] - 10;
                }
            }
            return m2;
        }
        public static Matrix operator *(Matrix m1, int a)
        {
            Matrix m2 = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m2[i, j] = m1[i, j] * a;
                }
            }
            return m2;
        }
        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            int tmp;
            Matrix result = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    tmp = result[i, j];
                    for (int k = 0; k < 2; k++)
                    {
                        tmp += m1[i, k] * m2[k, j];
                    }
                    result[i, j] = tmp;
                }
            }
            return result;
        }
        public static Matrix operator /(Matrix m1, int a)
        {
            Matrix m2 = new Matrix();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    m2[i, j] = m1[i, j] / a;
                }
            }
            return m2;
        }
        public static bool operator ==(Matrix m1, int a)
        {
            return (int)m1 == a;
        }
        public static bool operator !=(Matrix m1, int a)
        {
            return (int)m1 != a;
        }
        public static bool operator false(Matrix m1)
        {
            return (int)m1 == 0;
        }
        public static bool operator true(Matrix m1)
        {
            return (int)m1 != 0;
        }
        public override string ToString()
        {
            string strMatrix = "";
            for (int i = 0; i < 2; i++)
            {
                string str = "";
                str += matrix[i, 0].ToString() + ", ";
                str += matrix[i, 1].ToString();
                if (i == 0)
                    strMatrix += str + "\n";
                else
                    strMatrix += " " + str;
            }
            return strMatrix;
        }
        public static explicit operator int(Matrix m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }
        public static explicit operator Matrix(int d)
        {
            Matrix m2 = new Matrix((int)Math.Sqrt(d), (int)Math.Sqrt(d));
            return m2;
        }
    }
}
