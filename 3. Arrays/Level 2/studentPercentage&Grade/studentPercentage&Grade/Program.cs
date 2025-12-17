using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentPercentage_Grade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            double[] percentage = new double[n];
            char[] grade = new char[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Physics: ");
                double p = double.Parse(Console.ReadLine());
                Console.Write("Chemistry: ");
                double c = double.Parse(Console.ReadLine());
                Console.Write("Maths: ");
                double m = double.Parse(Console.ReadLine());

                percentage[i] = (p + c + m) / 3;

                if (percentage[i] >= 90) grade[i] = 'A';
                else if (percentage[i] >= 75) grade[i] = 'B';
                else if (percentage[i] >= 60) grade[i] = 'C';
                else grade[i] = 'D';
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"Percentage: {percentage[i]}, Grade: {grade[i]}");
        }
    }
}
