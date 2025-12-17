using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Interest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Principal: ");
            double principal = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Rate: ");
            double rate = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Time: ");
            double time = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("The Simple Interest is " + simpleInterest +
                              " for Principal " + principal +
                              ", Rate of Interest " + rate +
                              " and Time " + time);
        }
    }
}
