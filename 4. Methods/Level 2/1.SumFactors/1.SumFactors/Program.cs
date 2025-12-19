using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SumFactors
{
    internal class Program
    {
        static int[] FindFactors(int number)
        {
            int count = 0;
            for (int i = 1; i <= number; i++)
                if (number % i == 0) count++;

            int[] factors = new int[count];
            int index = 0;

            for (int i = 1; i <= number; i++)
                if (number % i == 0)
                    factors[index++] = i;

            return factors;
        }

        static int Sum(int[] arr)
        {
            int sum = 0;
            foreach (int x in arr) sum += x;
            return sum;
        }

        static int Product(int[] arr)
        {
            int prod = 1;
            foreach (int x in arr) prod *= x;
            return prod;
        }

        static double SumOfSquares(int[] arr)
        {
            double sum = 0;
            foreach (int x in arr)
                sum += Math.Pow(x, 2);
            return sum;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int[] factors = FindFactors(num);

            Console.WriteLine("Factors:");
            foreach (int f in factors) Console.Write(f + " ");

            Console.WriteLine("\nSum: " + Sum(factors));
            Console.WriteLine("Product: " + Product(factors));
            Console.WriteLine("Sum of Squares: " + SumOfSquares(factors));
        }
    }
}
