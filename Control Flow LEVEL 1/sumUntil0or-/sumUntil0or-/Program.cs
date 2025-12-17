using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumUntil0or_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;

            while (true)
            {
                double value = double.Parse(Console.ReadLine());
                if (value <= 0) break;
                total += value;
            }

            Console.WriteLine("Total = " + total);
        }
    }
}
