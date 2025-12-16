using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AveragePCM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int physics = 84;
            int chemistry = 89;
            int maths = 82;

            double average = (physics + chemistry + maths) / 3.0;
            Console.WriteLine("Average PCM score: " + average);
        }
    }
}
