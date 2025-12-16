using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positiveNegative
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = -10;

            string result = (number >= 0) ? "Positive" : "Negative";
            Console.WriteLine(result);
        }
    }
}
