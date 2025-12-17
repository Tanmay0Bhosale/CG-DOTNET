using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rocketCountdown
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = int.Parse(Console.ReadLine());

            while (counter >= 1)
            {
                Console.WriteLine(counter);
                counter--;
            }
    }
}
