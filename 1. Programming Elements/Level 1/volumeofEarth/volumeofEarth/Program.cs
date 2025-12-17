using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace volumeofEarth
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radiusKm = 6378;
            double volumeKm = (4.0 / 3.0) * Math.PI * Math.Pow(radiusKm, 3);
            double volumeMiles = volumeKm / Math.Pow(1.6, 3);

            Console.WriteLine("The volume of earth in cubic kilometers is " +
                              volumeKm + " and cubic miles is " + volumeMiles);
        }
    }
}
