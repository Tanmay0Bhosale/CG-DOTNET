using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialUsingFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n > 0)
            {
                int fact = 1;
                for (int i = 1; i <= n; i++)
                    fact *= i;

                Console.WriteLine(fact);
            }
        }
    }
}
