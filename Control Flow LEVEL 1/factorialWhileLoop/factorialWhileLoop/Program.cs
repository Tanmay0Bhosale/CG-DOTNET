using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                int fact = 1, i = 1;
                while (i <= n)
                {
                    fact *= i;
                    i++;
                }
                Console.WriteLine(fact);
            }
        }
    }
}
