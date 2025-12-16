using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feet_to_Yards___Miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());

            double yards = feet / 3;
            double miles = yards / 1760;

            Console.WriteLine("Distance in yards is " + yards +
                              " and in miles is " + miles);
        }
    }
}
