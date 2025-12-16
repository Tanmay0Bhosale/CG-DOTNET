using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateSimpleInterest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principal Amount, Rate of Interest and Time in Years:");
            Console.WriteLine("Principal Amount:");
            double principal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Time in Years:");
            double time = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rate of Interest:");
            double rate = Convert.ToDouble(Console.ReadLine());

            double simpleInterest = (principal * rate * time) / 100;

            Console.WriteLine("The simple INterest is :" + simpleInterest);

        }
    }
}
