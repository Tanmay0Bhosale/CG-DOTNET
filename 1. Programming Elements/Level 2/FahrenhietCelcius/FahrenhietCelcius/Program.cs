using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FahrenhietCelcius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature in Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());

            double celsius = (fahrenheit - 32) * 5 / 9;

            Console.WriteLine("The " + fahrenheit + " Fahrenheit is " + celsius + " Celsius");
        }
    }
}
