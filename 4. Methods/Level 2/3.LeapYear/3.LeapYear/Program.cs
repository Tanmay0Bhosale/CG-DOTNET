using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Level2;
namespace _3.LeapYear
{
    internal class Program
    {
        static bool IsLeapYear(int year)
        {
            if (year < 1582) return false;
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
        static void Main(string[] args)
        {
            Console.Write("Enter year: ");
            int year = int.Parse(Console.ReadLine());
            int res = unitConvertor.ConvertKmToMiles(12);
            Console.WriteLine(res);
            Console.WriteLine(IsLeapYear(year) ? "Leap Year" : "Not a Leap Year");
        }
    }
}
