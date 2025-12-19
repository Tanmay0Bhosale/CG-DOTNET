using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.euclianDistance
{
    internal class Program
    {
        
            static double Distance(double x1, double y1, double x2, double y2)
        => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            static double[] LineEquation(double x1, double y1, double x2, double y2)
            {
                double m = (y2 - y1) / (x2 - x1);
                double b = y1 - m * x1;
                return new double[] { m, b };
            }
    }
}
