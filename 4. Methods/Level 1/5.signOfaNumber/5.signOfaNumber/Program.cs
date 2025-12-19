using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.signOfaNumber
{
    internal class Program
    {
        static int sign(double nums)
        {
            if (nums < 0)
                return -1;
            else if (nums > 0)
                return 1;
            else
                return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number:");
            double nums = int.Parse(Console.ReadLine());

            int results = sign(nums);
            Console.WriteLine(results);
        }
    }
}
