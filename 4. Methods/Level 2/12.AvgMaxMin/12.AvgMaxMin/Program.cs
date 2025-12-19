using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.AvgMaxMin
{
    internal class Program
    {
        static int[] Generate4DigitRandomArray(int size)
        {
            Random rnd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
                arr[i] = rnd.Next(1000, 10000);

            return arr;
        }

        static double[] FindAverageMinMax(int[] numbers)
        {
            int min = numbers[0], max = numbers[0], sum = 0;

            foreach (int n in numbers)
            {
                sum += n;
                min = Math.Min(min, n);
                max = Math.Max(max, n);
            }

            return new double[] { (double)sum / numbers.Length, min, max };
        }
        static void Main(string[] args)
        {
            int[] arr = Generate4DigitRandomArray(5);

            Console.WriteLine("Numbers:");
            foreach (int n in arr) Console.Write(n + " ");

            double[] result = FindAverageMinMax(arr);
            Console.WriteLine("\nAverage: " + result[0]);
            Console.WriteLine("Min: " + result[1]);
            Console.WriteLine("Max: " + result[2]);
        }
    }
}
