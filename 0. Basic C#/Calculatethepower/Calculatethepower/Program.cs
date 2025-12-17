using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatethepower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the base and the power respectively:");
            Console.WriteLine("Base:");
            int bases = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Power:");
            int pow = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The result is : " + (Math.Pow(bases, pow)));

        }
    }
}
