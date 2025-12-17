using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace studentGradeCalculation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double physics = double.Parse(Console.ReadLine());
            double chemistry = double.Parse(Console.ReadLine());
            double maths = double.Parse(Console.ReadLine());

            double avg = (physics + chemistry + maths) / 3;
            string grade;

            if (avg >= 80) grade = "A";
            else if (avg >= 70) grade = "B";
            else if (avg >= 60) grade = "C";
            else if (avg >= 50) grade = "D";
            else if (avg >= 40) grade = "E";
            else grade = "R";

            Console.WriteLine($"Average = {avg}");
            Console.WriteLine($"Grade = {grade}");
        }
    }
}
