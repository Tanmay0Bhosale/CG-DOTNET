using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chocolates_Distribution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of chocolates: ");
            int chocolates = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of children: ");
            int children = Convert.ToInt32(Console.ReadLine());

            int eachGets = chocolates / children;
            int remaining = chocolates % children;

            Console.WriteLine("The number of chocolates each child gets is " +
                              eachGets + " and the number of remaining chocolates is " + remaining);
        }
    }
}
