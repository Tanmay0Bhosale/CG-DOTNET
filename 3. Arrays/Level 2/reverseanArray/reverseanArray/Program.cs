using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseanArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());

            int count = number.ToString().Length;
            int[] digits = new int[count];

            for (int i = 0; i < count; i++)
            {
                digits[i] = number % 10;
                number /= 10;
            }

            Console.Write("Reversed Number: ");
            for (int i = 0; i < count; i++)
                Console.Write(digits[i]);
        }
    }
}
