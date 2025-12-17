using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace countNumberofDIgits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int count = 0;

            while (number != 0)
            {
                number /= 10;
                count++;
            }

            Console.WriteLine("Number of digits = " + count);
        }
    }
}
