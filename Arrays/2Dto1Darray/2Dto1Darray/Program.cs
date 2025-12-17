using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Dto1Darray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            int[] array = new int[rows * cols];
            int index = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"Enter element [{i},{j}]: ");
                    matrix[i, j] = int.Parse(Console.ReadLine());
                    array[index++] = matrix[i, j];
                }
            }

            Console.WriteLine("\n1D Array:");
            foreach (int item in array)
                Console.Write(item + " ");
        }
    }
}
