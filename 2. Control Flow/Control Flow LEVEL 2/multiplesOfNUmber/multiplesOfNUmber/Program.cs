using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplesOfNUmber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 100; i >= 1; i--)
            {
                if (i % number == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
