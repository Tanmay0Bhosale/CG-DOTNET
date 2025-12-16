using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolumeOfCylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the cyclinder:");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the height of the cylinder:");
            int height = Convert.ToInt32(Console.ReadLine());

            double volume = Math.PI * radius * radius * height;

            Console.WriteLine("The Volume of the Cylinder is :" + volume);

         
        }
    }
}
