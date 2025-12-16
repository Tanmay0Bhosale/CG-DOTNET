using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_KM_to_Miles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter distance in km: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double miles = km / 1.6;

            Console.WriteLine("The total miles is " + miles + " mile for the given " + km + " km");
        }
    }
}
