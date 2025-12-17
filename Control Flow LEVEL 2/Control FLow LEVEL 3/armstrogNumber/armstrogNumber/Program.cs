using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace armstrogNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int originalNumber = number;
            int sum = 0;

            while (originalNumber != 0)
            {
                int remainder = originalNumber % 10;
                sum += remainder * remainder * remainder;
                originalNumber /= 10;
            }

            if (sum == number)
                Console.WriteLine("Armstrong Number");
            else
                Console.WriteLine("Not an Armstrong Number");
        }
    }
}
