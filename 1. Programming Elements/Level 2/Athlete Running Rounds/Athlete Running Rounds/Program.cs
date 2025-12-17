using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Athlete_Running_Rounds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1 (meters): ");
            double side1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 2 (meters): ");
            double side2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter side 3 (meters): ");
            double side3 = Convert.ToDouble(Console.ReadLine());

            double perimeter = side1 + side2 + side3;
            double rounds = 5000 / perimeter;

            Console.WriteLine("The total number of rounds the athlete will run is " + rounds);
        }
    }
}
