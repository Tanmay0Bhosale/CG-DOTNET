using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year u want to check:");
            int year = int.Parse(Console.ReadLine());

            bool isLeap = (year >= 1582) &&
                          ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0));

            Console.WriteLine(isLeap ? "Leap Year" : "Not a Leap Year");
        }
    }
}
