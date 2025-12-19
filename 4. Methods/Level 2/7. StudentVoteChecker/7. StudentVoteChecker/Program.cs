using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.StudentVoteChecker
{
    internal class Program
    {
        public static bool CanStudentVote(int age)
        {
            if (age < 0) return false;
            return age >= 18;
        }
        static void Main(string[] args)
        {
            int[] ages = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter age of student {i + 1}: ");
                ages[i] = int.Parse(Console.ReadLine());

                Console.WriteLine(CanStudentVote(ages[i]) ? "Can Vote" : "Cannot Vote");
            }
        }
    }
}
