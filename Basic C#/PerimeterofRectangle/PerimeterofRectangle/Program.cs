using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterofRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Eneter the Lenght of the Rectangle:");
            double length = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Eneter the Width of the Rectangle:");
            double width = Convert.ToDouble(Console.ReadLine());

            double perimeter = 2 * (length + width);
            Console.WriteLine("the perimeter of the rectangle is :" + perimeter);
        }
    }
}
