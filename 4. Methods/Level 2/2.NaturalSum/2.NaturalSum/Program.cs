using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.NaturalSum
{
    internal class Program
    {
        static int RecursiveSum(int n)
        {
            if (n == 0) return 0;
            return n + RecursiveSum(n - 1);
        }

        static int FormulaSum(int n)
        {
            return n * (n + 1) / 2;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a natural number: ");
            int n = int.Parse(Console.ReadLine());

            if (n < 0)
            {
                Console.WriteLine("Not a natural number");
                return;
            }

            int r1 = RecursiveSum(n);
            int r2 = FormulaSum(n);

            Console.WriteLine("Recursive Sum: " + r1);
            Console.WriteLine("Formula Sum: " + r2);
            Console.WriteLine("Results Match: " + (r1 == r2));
        }
    }
}
