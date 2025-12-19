using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.calculateTrigonometricFunctions
{
    internal class Program
    {
        public static double[] calculateTrigonometricFunctions(double angle)
        {
            double radians = angle * Math.PI / 180;

            double sin = Math.Sin(radians);
            double cos = Math.Cos(radians);
            double tan = Math.Tan(radians);

            return new double[] { sin, cos, tan };
        }
        static void Main(string[] args)
        {
            Console.Write("Enter angle in degrees: ");
            double angle = double.Parse(Console.ReadLine());

            double[] result = calculateTrigonometricFunctions(angle);

            Console.WriteLine("Sine: " + result[0]);
            Console.WriteLine("Cosine: " + result[1]);
            Console.WriteLine("Tangent: " + result[2]);
        }
    }
}
