using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace springSeason
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int month = int.Parse(args[0]);
            int day = int.Parse(args[1]);

            bool isSpring =
                (month == 3 && day >= 20) ||
                (month == 4) ||
                (month == 5) ||
                (month == 6 && day <= 20);

            Console.WriteLine(isSpring ? "Its a Spring Season" : "Not a Spring Season");
        }
    }
}
