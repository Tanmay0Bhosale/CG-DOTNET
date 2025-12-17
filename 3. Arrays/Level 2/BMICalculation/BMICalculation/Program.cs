using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of persons: ");
            int n = int.Parse(Console.ReadLine());

            double[] weight = new double[n];
            double[] height = new double[n];
            double[] bmi = new double[n];
            string[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter weight (kg): ");
                weight[i] = double.Parse(Console.ReadLine());

                Console.Write("Enter height (m): ");
                height[i] = double.Parse(Console.ReadLine());

                bmi[i] = weight[i] / (height[i] * height[i]);

                if (bmi[i] < 18.5) status[i] = "Underweight";
                else if (bmi[i] < 25) status[i] = "Normal";
                else if (bmi[i] < 30) status[i] = "Overweight";
                else status[i] = "Obese";
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"Height: {height[i]}, Weight: {weight[i]}, BMI: {bmi[i]}, Status: {status[i]}");
        }
    }
}
