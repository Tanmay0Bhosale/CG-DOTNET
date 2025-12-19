using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.studenMarks
{
    internal class Program
    {
        static int[,] GeneratePCM(int students)
        {
            Random r = new Random();
            int[,] marks = new int[students, 3];

            for (int i = 0; i < students; i++)
                for (int j = 0; j < 3; j++)
                    marks[i, j] = r.Next(10, 100);

            return marks;
        }

        static double[,] CalculateResults(int[,] marks)
        {
            int n = marks.GetLength(0);
            double[,] result = new double[n, 3]; // total, avg, %

            for (int i = 0; i < n; i++)
            {
                double total = marks[i, 0] + marks[i, 1] + marks[i, 2];
                double avg = total / 3;
                double percent = (total / 300) * 100;

                result[i, 0] = Math.Round(total, 2);
                result[i, 1] = Math.Round(avg, 2);
                result[i, 2] = Math.Round(percent, 2);
            }
            return result;
        }

        static void Display(int[,] marks, double[,] result)
        {
            Console.WriteLine("Phy\tChem\tMath\tTotal\tAvg\tPercent");
            for (int i = 0; i < marks.GetLength(0); i++)
            {
                Console.WriteLine(
                    $"{marks[i, 0]}\t{marks[i, 1]}\t{marks[i, 2]}\t" +
                    $"{result[i, 0]}\t{result[i, 1]}\t{result[i, 2]}"
                );
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[,] marks = GeneratePCM(n);
            double[,] result = CalculateResults(marks);
            Display(marks, result);
        }
    }
}
