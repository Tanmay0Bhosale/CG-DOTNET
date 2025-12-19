using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.numberHandshakes
{
    internal class Program
    {
        static int handshakes(int persons)
        {
            int answer = (persons * (persons - 1)) / 2;
            return answer;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of persons:");
            int persons = int.Parse(Console.ReadLine());

            int results =handshakes(persons);
            Console.WriteLine(results);
        }
    }
}
