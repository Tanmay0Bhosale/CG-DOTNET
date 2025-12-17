using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace checkNumSign
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            if (number > 0) Console.WriteLine("Positive");
            else if (number < 0) Console.WriteLine("Negative");
            else Console.WriteLine("Zero");

        }
    }
}
