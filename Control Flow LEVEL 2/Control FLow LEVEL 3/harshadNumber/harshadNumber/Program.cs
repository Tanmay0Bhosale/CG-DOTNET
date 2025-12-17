using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harshadNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int temp = number;
            int sum = 0;

            while (temp != 0)
            {
                sum += temp % 10;
                temp /= 10;
            }

            if (number % sum == 0)
                Console.WriteLine("Harshad Number");
            else
                Console.WriteLine("Not a Harshad Number");
        }
    }
}
