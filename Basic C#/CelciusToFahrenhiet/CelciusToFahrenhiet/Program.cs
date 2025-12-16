using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CelciusToFahrenhiet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the temperature in Celsius:");
            double celcius = Convert.ToDouble(Console.ReadLine());

            double farhenhiet = (celcius * 9 / 5) + 32;
            Console.WriteLine("The temperature in Fahrenhiet is:" + farhenhiet);

        }
    }
}
