using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeUntil0orNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[10];
            double total = 0.0;
            int index = 0;

            while (true)
            {
                Console.Write("Enter a number: ");
                double input = double.Parse(Console.ReadLine());

                if (input <= 0 || index == 10)
                    break;

                numbers[index] = input;
                index++;
            }

            Console.WriteLine("\nNumbers entered:");

            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(numbers[i]);
                total += numbers[i];
            }

            Console.WriteLine($"Total = {total}"); 
        }
    }
}
