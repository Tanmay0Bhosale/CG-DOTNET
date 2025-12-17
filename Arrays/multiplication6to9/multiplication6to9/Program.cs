using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplication6to9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            int[] results = new int[4];

            int index = 0;
            for (int i = 6; i <= 9; i++)
            {
                results[index++] = number * i;
            }

            index = 0;
            for (int i = 6; i <= 9; i++)
            {
                Console.WriteLine($"{number} * {i} = {results[index++]}");
            }
        }
    }
}
