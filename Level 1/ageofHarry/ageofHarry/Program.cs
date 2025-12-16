using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ageofHarry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int birthYear = 2004;
            int currentYear = DateTime.Now.Year;

            int age = currentYear - birthYear;
            Console.WriteLine("Harry is " + age + " years old.");
        }
    }
}
