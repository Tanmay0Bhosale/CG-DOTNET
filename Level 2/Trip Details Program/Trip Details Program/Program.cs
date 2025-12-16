using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip_Details_Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter From City: ");
            string fromCity = Console.ReadLine();

            Console.Write("Enter Via City: ");
            string viaCity = Console.ReadLine();

            Console.Write("Enter To City: ");
            string toCity = Console.ReadLine();

            Console.Write("Enter distance from source to via (miles): ");
            double fromToVia = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter distance from via to destination (miles): ");
            double viaToFinalCity = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter time taken (hours): ");
            double timeTaken = Convert.ToDouble(Console.ReadLine());

            double totalDistance = fromToVia + viaToFinalCity;
            double speed = totalDistance / timeTaken;

            Console.WriteLine("The results of the trip are: " +
                              totalDistance + ", " + timeTaken + ", " + speed);
        }
    }
}
