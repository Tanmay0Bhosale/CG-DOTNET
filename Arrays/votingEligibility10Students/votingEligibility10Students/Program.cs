using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace votingEligibility10Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] ages = new int[10];

            for (int i = 0; i < ages.Length; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nVoting Eligibility:");

            for (int i = 0; i < ages.Length; i++)
            {
                if (ages[i] < 0)
                    Console.WriteLine("Invalid age");
                else if (ages[i] >= 18)
                    Console.WriteLine($"The student with the age {ages[i]} can vote");
                else
                    Console.WriteLine($"The student with the age {ages[i]} cannot vote");
            }
        }
    }
}
