using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Triangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter base: ");
            double baseVal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double area = 0.5 * baseVal * height;

            Console.WriteLine("Area of triangle is " + area);
        }
    }
}
