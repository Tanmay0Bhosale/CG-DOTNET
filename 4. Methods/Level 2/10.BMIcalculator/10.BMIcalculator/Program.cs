using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.BMIcalculator
{
    internal class Program
    {
        static void CalculateBMI(double[,] data)
        {
            for (int i = 0; i < 10; i++)
            {
                double heightM = data[i, 1] / 100;
                data[i, 2] = data[i, 0] / (heightM * heightM);
            }
        }

        static void Main(string[] args)
        {
            double[,] persons = new double[10, 3];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter weight of person {i + 1}: ");
                persons[i, 0] = double.Parse(Console.ReadLine());

                Console.Write($"Enter height (cm) of person {i + 1}: ");
                persons[i, 1] = double.Parse(Console.ReadLine());
            }

            CalculateBMI(persons);

            for (int i = 0; i < 10; i++)
                Console.WriteLine($"BMI of person {i + 1}: {persons[i, 2]:F2}");
        }
    }
}
