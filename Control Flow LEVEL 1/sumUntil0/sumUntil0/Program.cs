using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumUntil0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double value;

            while ((value = double.Parse(Console.ReadLine())) != 0)
            {
                total += value;
            }

            Console.WriteLine("Total = " + total);
        }
    }
}
