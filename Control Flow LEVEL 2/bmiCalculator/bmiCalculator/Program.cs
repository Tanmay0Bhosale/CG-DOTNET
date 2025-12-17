using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmiCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = double.Parse(Console.ReadLine());
            double heightCm = double.Parse(Console.ReadLine());

            double heightM = heightCm / 100;
            double bmi = weight / (heightM * heightM);

            Console.WriteLine("BMI = " + bmi);
        }
    }
}
