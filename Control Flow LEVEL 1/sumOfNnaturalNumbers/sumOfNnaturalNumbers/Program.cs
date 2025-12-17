using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumOfNnaturalNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n >= 0)
            {
                int sumLoop = 0, i = 1;
                while (i <= n)
                {
                    sumLoop += i;
                    i++;
                }

                int sumFormula = n * (n + 1) / 2;
                Console.WriteLine($"While Loop Sum: {sumLoop}");
                Console.WriteLine($"Formula Sum: {sumFormula}");
            }
        }
    }
}
