using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.SimpleInterest
{
    internal class Program
    {
        static double calculateSI(double principal,double rate,double time)
        {
            double si = (principal * rate * time)/100;
            return si;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Principal Amount:");
            double principal = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate Percentage:");
            double rate = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Principal Amount:");
            double time = double.Parse(Console.ReadLine());

            double result = calculateSI(principal, rate, time);

            Console.WriteLine($"The Simple Interest is {result} for the principal {principal}, rate {rate} and time {time}");
        }
    }
}
