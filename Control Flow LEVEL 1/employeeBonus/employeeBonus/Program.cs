using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double salary = double.Parse(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());

            if (years > 5)
                Console.WriteLine("Bonus = " + (salary * 0.05));
            else
                Console.WriteLine("No Bonus");
        }
    }
}
