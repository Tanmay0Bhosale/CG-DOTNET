using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pensDistribution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = 14;
            int students = 3;

            int pensPerStudent = pens / students;
            int remainingPens = pens % students;

            Console.WriteLine("The Pen Per Student is " + pensPerStudent +
                              " and the remaining pen not distributed is " + remainingPens);
        }
    }
}
