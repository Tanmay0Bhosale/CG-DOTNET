using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negativeZeroPositive_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    if (numbers[i] % 2 == 0)
                        Console.WriteLine($"{numbers[i]} is Positive and Even");
                    else
                        Console.WriteLine($"{numbers[i]} is Positive and Odd");
                }
                else if (numbers[i] < 0)
                    Console.WriteLine($"{numbers[i]} is Negative");
                else
                    Console.WriteLine("Number is Zero");
            }

            Console.WriteLine();

            if (numbers[0] == numbers[4])
                Console.WriteLine("First and last elements are Equal");
            else if (numbers[0] > numbers[4])
                Console.WriteLine("First element is Greater than last");
            else
                Console.WriteLine("First element is Less than last");
        }
    }
}
