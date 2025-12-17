using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculatorusingSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double first = double.Parse(Console.ReadLine());
            double second = double.Parse(Console.ReadLine());
            string op = Console.ReadLine();

            switch (op)
            {
                case "+":
                    Console.WriteLine(first + second);
                    break;
                case "-":
                    Console.WriteLine(first - second);
                    break;
                case "*":
                    Console.WriteLine(first * second);
                    break;
                case "/":
                    Console.WriteLine(first / second);
                    break;
                default:
                    Console.WriteLine("Invalid Operator");
                    break;
            }
        }
    }
}
