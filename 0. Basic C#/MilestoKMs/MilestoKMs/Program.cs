using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilestoKMs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter miles to convert to kilometers:");
            double miles = Convert.ToDouble(Console.ReadLine());
            double kilometers = miles * 1.60934;
            Console.WriteLine("{0} miles is equal to {1} kilometers.", miles, kilometers);
        }
    }
}
