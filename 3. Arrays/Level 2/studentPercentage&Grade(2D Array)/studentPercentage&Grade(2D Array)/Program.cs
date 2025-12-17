using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentPercentage_Grade_2D_Array_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter students count: ");
            int n = int.Parse(Console.ReadLine());

            double[,] marks = new double[n, 3];
            double[] percentage = new double[n];
            char[] grade = new char[n];

            for (int i = 0; i < n; i++)
            {
                marks[i, 0] = double.Parse(Console.ReadLine());
                marks[i, 1] = double.Parse(Console.ReadLine());
                marks[i, 2] = double.Parse(Console.ReadLine());

                percentage[i] = (marks[i, 0] + marks[i, 1] + marks[i, 2]) / 3;

                grade[i] = percentage[i] >= 75 ? 'A' : 'B';
            }

            for (int i = 0; i < n; i++)
                Console.WriteLine($"Percentage: {percentage[i]}, Grade: {grade[i]}");
        }
    }
}
