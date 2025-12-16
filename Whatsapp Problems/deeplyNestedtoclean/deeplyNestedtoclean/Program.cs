using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deeplyNestedtoclean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Converting the Deeply Nested to Clean Code Example");
            int marks = 75;

            if (marks < 0 || marks > 100)
                return;

            if (marks >= 40)
                Console.WriteLine("Student Passed");
            else
                Console.WriteLine("Student Failed");

        }
    }
}
