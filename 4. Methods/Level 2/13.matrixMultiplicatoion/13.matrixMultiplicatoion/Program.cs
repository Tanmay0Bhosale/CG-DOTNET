using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.matrixMultiplicatoion
{
    internal class Program
    {
        static int[,] CreateMatrix(int r, int c)
        {
            Random rand = new Random();
            int[,] m = new int[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    m[i, j] = rand.Next(1, 10);
            return m;
        }

        static int[,] Add(int[,] a, int[,] b)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            int[,] res = new int[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    res[i, j] = a[i, j] + b[i, j];
            return res;
        }

        static int[,] Subtract(int[,] a, int[,] b)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            int[,] res = new int[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    res[i, j] = a[i, j] - b[i, j];
            return res;
        }

        static int[,] Multiply(int[,] a, int[,] b)
        {
            int[,] res = new int[a.GetLength(0), b.GetLength(1)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < b.GetLength(1); j++)
                    for (int k = 0; k < b.GetLength(0); k++)
                        res[i, j] += a[i, k] * b[k, j];
            return res;
        }

        static int[,] Transpose(int[,] a)
        {
            int[,] t = new int[a.GetLength(1), a.GetLength(0)];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    t[j, i] = a[i, j];
            return t;
        }

        static int Determinant2x2(int[,] m)
        {
            return m[0, 0] * m[1, 1] - m[0, 1] * m[1, 0];
        }

        static int Determinant3x3(int[,] m)
        {
            return
                m[0, 0] * (m[1, 1] * m[2, 2] - m[1, 2] * m[2, 1]) -
                m[0, 1] * (m[1, 0] * m[2, 2] - m[1, 2] * m[2, 0]) +
                m[0, 2] * (m[1, 0] * m[2, 1] - m[1, 1] * m[2, 0]);
        }

        static void Display(int[,] m)
        {
            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                    Console.Write(m[i, j] + "\t");
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            int[,] A = CreateMatrix(2, 2);
            int[,] B = CreateMatrix(2, 2);

            Console.WriteLine("Matrix A:");
            Display(A);

            Console.WriteLine("Matrix B:");
            Display(B);

            Console.WriteLine("Addition:");
            Display(Add(A, B));

            Console.WriteLine("Subtraction:");
            Display(Subtract(A, B));

            Console.WriteLine("Multiplication:");
            Display(Multiply(A, B));

            Console.WriteLine("Transpose of A:");
            Display(Transpose(A));

            Console.WriteLine("Determinant of A: " + Determinant2x2(A));
        }
    }
}
