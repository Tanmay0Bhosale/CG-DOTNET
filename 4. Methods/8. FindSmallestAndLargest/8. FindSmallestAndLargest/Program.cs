using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.FindSmallestAndLargest
{
    internal class Program
    {
        public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
        {
            int smallest = number1;
            int largest = number1;

            if (number2 < smallest) smallest = number2;
            if (number3 < smallest) smallest = number3;

            if (number2 > largest) largest = number2;   
            if (number3 > largest) largest = number3;

            return new int[] { smallest, largest };
        }
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            int[] result = FindSmallestAndLargest(a, b, c);

            Console.WriteLine("Smallest: " + result[0]);
            Console.WriteLine("Largest: " + result[1]);
        }
    }
}
