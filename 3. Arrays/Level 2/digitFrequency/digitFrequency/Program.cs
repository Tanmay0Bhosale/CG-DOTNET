using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitFrequency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int[] freq = new int[10];

            while (number != 0)
            {
                freq[number % 10]++;
                number /= 10;
            }

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"Digit {i} appears {freq[i]} times");
        }
    }
}
