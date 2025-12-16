using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_Handshakes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of students: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int handshakes = (n * (n - 1)) / 2;

            Console.WriteLine("The maximum number of handshakes is " + handshakes);
        }
    }
}
