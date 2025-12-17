using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace naturalNumSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                int sum = n * (n + 1) / 2;
                Console.WriteLine($"The sum of {n} natural numbers is {sum}");
            }
            else
            {
                Console.WriteLine($"The number {n} is not a natural number");
            }
        }
    }
}
