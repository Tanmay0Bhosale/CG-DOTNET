using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeSalary_Bonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] salary = new double[10];
            double[] years = new double[10];
            double[] bonus = new double[10];
            double[] newSalary = new double[10];

            double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter salary of employee {i + 1}: ");
                salary[i] = double.Parse(Console.ReadLine());

                Console.Write($"Enter years of service of employee {i + 1}: ");
                years[i] = double.Parse(Console.ReadLine());

                if (salary[i] <= 0 || years[i] < 0)
                {
                    Console.WriteLine("Invalid input. Enter again.");
                    i--;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                if (years[i] > 5)
                    bonus[i] = salary[i] * 0.05;
                else
                    bonus[i] = salary[i] * 0.02;

                newSalary[i] = salary[i] + bonus[i];

                totalBonus += bonus[i];
                totalOldSalary += salary[i];
                totalNewSalary += newSalary[i];
            }

            Console.WriteLine($"\nTotal Bonus Paid: {totalBonus}");
            Console.WriteLine($"Total Old Salary: {totalOldSalary}");
            Console.WriteLine($"Total New Salary: {totalNewSalary}");
        }
    }
}
