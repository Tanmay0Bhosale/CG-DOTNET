using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sideofSquare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter perimeter: ");
            double perimeter = Convert.ToDouble(Console.ReadLine());

            double side = perimeter / 4;

            Console.WriteLine("The length of the side is " + side +
                              " whose perimeter is " + perimeter);
        }
    }
}
