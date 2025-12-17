using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace youngestTallest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageAmar = int.Parse(Console.ReadLine());
            int ageAkbar = int.Parse(Console.ReadLine());
            int ageAnthony = int.Parse(Console.ReadLine());

            double hAmar = double.Parse(Console.ReadLine());
            double hAkbar = double.Parse(Console.ReadLine());
            double hAnthony = double.Parse(Console.ReadLine());

            int youngest = Math.Min(ageAmar, Math.Min(ageAkbar, ageAnthony));
            double tallest = Math.Max(hAmar, Math.Max(hAkbar, hAnthony));

            Console.WriteLine("Youngest Age = " + youngest);
            Console.WriteLine("Tallest Height = " + tallest);
        }
    }
}
