using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Addition: " + (number1 + number2));
            Console.WriteLine("Subtraction: " + (number1 - number2));
            Console.WriteLine("Multiplication: " + (number1 * number2));
            Console.WriteLine("Division: " + (number1 / number2));
        }
    }
}
