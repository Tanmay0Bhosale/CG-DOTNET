using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            if ((num % 3 == 0 || num % 5 == 0) && !(num % 3 == 0 && num % 5 == 0))
                Console.WriteLine("Divisible by 3 or 5 but not both");
            else
                Console.WriteLine("Condition not satisfied");
        }
    }
}
