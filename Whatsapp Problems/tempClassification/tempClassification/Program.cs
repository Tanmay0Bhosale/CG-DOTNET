using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tempClassification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter temperature: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp < 0)
                Console.WriteLine("Freezing");
            else if (temp <= 20)
                Console.WriteLine("Cold");
            else if (temp <= 35)
                Console.WriteLine("Warm");
            else
                Console.WriteLine("Hot");
        }
    }
}
