using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_a_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            int result = 1;

            for (int i = 1; i <= power; i++)
                result *= number;

            Console.WriteLine(result);
        }
    }
}
