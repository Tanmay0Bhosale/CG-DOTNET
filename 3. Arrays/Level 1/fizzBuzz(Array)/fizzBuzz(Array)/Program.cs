using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int number = int.Parse(Console.ReadLine());

            if (number <= 0)
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string[] result = new string[number + 1];

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    result[i] = "FizzBuzz";
                else if (i % 3 == 0)
                    result[i] = "Fizz";
                else if (i % 5 == 0)
                    result[i] = "Buzz";
                else
                    result[i] = i.ToString();
            }

            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine($"Position {i} = {result[i]}");
            }
        }
    }
}
