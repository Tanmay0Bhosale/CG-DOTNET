using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.ChocolatesDistribution
{
    internal class Program
    {
        public static int[] FindRemainderAndQuotient(int chocolates, int children)
        {
            int eachChildGets = chocolates / children;
            int remaining = chocolates % children;

            return new int[] { eachChildGets, remaining };
        }
        static void Main(string[] args)
        {
            Console.Write("Enter number of chocolates: ");
            int chocolates = int.Parse(Console.ReadLine());

            Console.Write("Enter number of children: ");
            int children = int.Parse(Console.ReadLine());

            int[] result = FindRemainderAndQuotient(chocolates, children);

            Console.WriteLine("Each child gets: " + result[0]);
            Console.WriteLine("Remaining chocolates: " + result[1]);
        }
    }
}
