using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.employeBonus
{
    internal class Program
    {
        static double[,] GenerateEmployeeData(int count)
        {
            Random r = new Random();
            double[,] data = new double[count, 2]; // salary, years

            for (int i = 0; i < count; i++)
            {
                data[i, 0] = r.Next(10000, 100000); // salary
                data[i, 1] = r.Next(1, 11);         // years of service
            }
            return data;
        }

        static double[,] CalculateBonus(double[,] data)
        {
            int n = data.GetLength(0);
            double[,] result = new double[n, 3]; // old, bonus, new

            for (int i = 0; i < n; i++)
            {
                double salary = data[i, 0];
                double years = data[i, 1];
                double bonus = (years > 5) ? salary * 0.05 : salary * 0.02;

                result[i, 0] = salary;
                result[i, 1] = bonus;
                result[i, 2] = salary + bonus;
            }
            return result;
        }

        static void Display(double[,] result)
        {
            double totalOld = 0, totalBonus = 0, totalNew = 0;

            Console.WriteLine("OldSalary\tBonus\t\tNewSalary");
            for (int i = 0; i < result.GetLength(0); i++)
            {
                Console.WriteLine($"{result[i, 0]}\t\t{result[i, 1]:F2}\t\t{result[i, 2]:F2}");
                totalOld += result[i, 0];
                totalBonus += result[i, 1];
                totalNew += result[i, 2];
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{totalOld}\t\t{totalBonus:F2}\t\t{totalNew:F2}");
        }
        static void Main(string[] args)
        {
            double[,] data = GenerateEmployeeData(10);
            double[,] result = CalculateBonus(data);
            Display(result);
        }
    }
}
