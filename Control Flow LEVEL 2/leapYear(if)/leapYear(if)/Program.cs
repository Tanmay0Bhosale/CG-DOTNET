using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leapYear_if_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());

            if (year >= 1582 && ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0)))
                Console.WriteLine("Leap Year");
            else
                Console.WriteLine("Not a Leap Year");
        }
    }
}
