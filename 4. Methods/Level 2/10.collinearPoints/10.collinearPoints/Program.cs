using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.collinearPoints
{
    internal class Program
    {
        static bool IsCollinear(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            double area = 0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2));
            return area == 0;
        }
    }
}
