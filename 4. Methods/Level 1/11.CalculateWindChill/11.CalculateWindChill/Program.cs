using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.CalculateWindChill
{
    internal class Program
    {
        public static double CalculateWindChill(double temperature, double windSpeed)
        {
            double windChill = 35.74
                               + 0.6215 * temperature
                               + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
            return windChill;
        }
        static void Main(string[] args)
        {
            Console.Write("Enter temperature: ");
            double temp = double.Parse(Console.ReadLine());

            Console.Write("Enter wind speed: ");
            double speed = double.Parse(Console.ReadLine());

            double result = CalculateWindChill(temp, speed);

            Console.WriteLine("Wind Chill Temperature: " + result);
        }
    }
}
