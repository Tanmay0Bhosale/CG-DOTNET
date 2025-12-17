using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_2D_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter persons count: ");
            int n = int.Parse(Console.ReadLine());

            double[][] personData = new double[n][];
            string[] status = new string[n];

            for (int i = 0; i < n; i++)
            {
                personData[i] = new double[3];

                Console.Write("Enter weight: ");
                personData[i][0] = double.Parse(Console.ReadLine());

                Console.Write("Enter height: ");
                personData[i][1] = double.Parse(Console.ReadLine());

                personData[i][2] = personData[i][0] / (personData[i][1] * personData[i][1]);

                if (personData[i][2] < 18.5) status[i] = "Underweight";
                else if (personData[i][2] < 25) status[i] = "Normal";
                else if (personData[i][2] < 30) status[i] = "Overweight";
                else status[i] = "Obese";
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"Weight: {personData[i][0]}, Height: {personData[i][1]}, BMI: {personData[i][2]}, Status: {status[i]}");
        }
    }
}
