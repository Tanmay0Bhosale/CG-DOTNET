using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nNaturalNUMusingFor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                int sum = 0;
                for (int i = 1; i <= n; i++)
                    sum += i;

                int formula = n * (n + 1) / 2;
                Console.WriteLine($"For Loop Sum: {sum}");
                Console.WriteLine($"Formula Sum: {formula}");
            }
        }
    }
}
