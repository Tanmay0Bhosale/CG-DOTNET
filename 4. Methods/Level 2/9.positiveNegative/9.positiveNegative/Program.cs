using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.positiveNegative
{
    internal class Program
    {
        static bool IsPositive(int n) => n >= 0;
        static bool IsEven(int n) => n % 2 == 0;

        static int Compare(int a, int b)
        {
            if (a > b) return 1;
            if (a == b) return 0;
            return -1;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                arr[i] = int.Parse(Console.ReadLine());

                if (IsPositive(arr[i]))
                    Console.WriteLine(IsEven(arr[i]) ? "Positive Even" : "Positive Odd");
                else
                    Console.WriteLine("Negative");
            }

            int result = Compare(arr[0], arr[4]);
            Console.WriteLine(result == 0 ? "Equal" : result == 1 ? "First Greater" : "First Smaller");
        }
    }
}
