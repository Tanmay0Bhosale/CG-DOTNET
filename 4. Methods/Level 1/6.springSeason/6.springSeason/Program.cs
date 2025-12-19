using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.springSeason
{
    internal class Program
    {
        static string Spring(int day,int months)
        {
            if ((months == 3 && day >= 20 && day <= 31) ||
               (months == 4 && day >= 1 && day <= 30) ||
               (months == 5 && day >= 1 && day <= 31) ||
               (months == 6 && day >= 1 && day <= 20))
            {
                return "Spring Season";
            }
            else
                return "Not a Spring Season";
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the month and the day in numbers:");
            Console.WriteLine("Enter the month in numbers :");
            int months = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the day:");
            int day = int.Parse(Console.ReadLine());

            string result = Spring(day, months);
            Console.WriteLine(result);
        }
    }
}
