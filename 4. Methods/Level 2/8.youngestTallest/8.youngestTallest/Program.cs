using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.youngestTallest
{
    internal class Program
    {
        static int FindYoungest(int[] ages)
        {
            int min = ages[0];
            foreach (int a in ages) if (a < min) min = a;
            return min;
        }

        static int FindTallest(int[] heights)
        {
            int max = heights[0];
            foreach (int h in heights) if (h > max) max = h;
            return max;
        }
        static void Main(string[] args)
        {
            int[] ages = new int[3];
            int[] heights = new int[3];
            string[] names = { "Amar", "Akbar", "Anthony" };

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Enter age of {names[i]}: ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.Write($"Enter height of {names[i]}: ");
                heights[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Youngest Age: " + FindYoungest(ages));
            Console.WriteLine("Tallest Height: " + FindTallest(heights));
        }
    }
}
