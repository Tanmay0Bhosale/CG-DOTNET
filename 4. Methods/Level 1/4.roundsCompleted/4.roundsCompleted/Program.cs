using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.roundsCompleted
{
    internal class Program
    {
        static double rounds(double side1, double side2, double side3)
        {
            double one_round = side1 + side2 + side3;
            double answer = 5000 / one_round;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Side of the Traingle :");
            Console.WriteLine("Enter the Side1:");
            double side1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Side2:");
            double side2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Side3:");
            double side3 = double.Parse(Console.ReadLine());


            double results = rounds(side1, side2, side3);
            Console.WriteLine(results);
        }
    }
}
