using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int[] table = new int[10];

            for (int i = 1; i <= 10; i++)
            {
                table[i - 1] = number * i;
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} * {i} = {table[i - 1]}");
            }
        }
    }
}
