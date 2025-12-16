using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace absoluteNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number :");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 0)
            {
                num = num * -1;
            }

            Console.WriteLine("The absolute value of the number is: " + num);
        }
    }
}
