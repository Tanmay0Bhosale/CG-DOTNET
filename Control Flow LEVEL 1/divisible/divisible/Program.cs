using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisible
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to see if it is divisible by 5:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((number%5 ==0) ? "The number is divisible by 5." : "The number is not divisible by 5.");
        }
    }
}
