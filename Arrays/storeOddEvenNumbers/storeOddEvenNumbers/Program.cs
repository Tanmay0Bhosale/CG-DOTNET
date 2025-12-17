using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace storeOddEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid natural number");
                return;
            }

            int[] even = new int[number / 2 + 1];
            int[] odd = new int[number / 2 + 1];

            int evenIndex = 0, oddIndex = 0;

            for (int i = 1; i <= number; i++)
            {
                if (i % 2 == 0)
                    even[evenIndex++] = i;
                else
                    odd[oddIndex++] = i;
            }

            Console.WriteLine("\nOdd Numbers:");
            for (int i = 0; i < oddIndex; i++)
                Console.Write(odd[i] + " ");

            Console.WriteLine("\n\nEven Numbers:");
            for (int i = 0; i < evenIndex; i++)
                Console.Write(even[i] + " ");
        }
    }
}
