using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.SumOfNaturalNumbers
{
    internal class Program
    {
        static int SumOfNaturalNumbers(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());

            int result = SumOfNaturalNumbers(n);
            Console.WriteLine("Sum of first " + n + " natural numbers is: " + result);
        }
    }
}
