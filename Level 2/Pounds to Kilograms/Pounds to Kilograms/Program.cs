using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pounds_to_Kilograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter weight in pounds: ");
            double pounds = Convert.ToDouble(Console.ReadLine());

            double kg = pounds / 2.2;

            Console.WriteLine("The weight of the person in pounds is " +
                              pounds + " and in kg is " + kg);
        }
    }
}
