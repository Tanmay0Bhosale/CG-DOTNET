using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.otpGenerator
{
    internal class Program
    {
        static int GenerateOTP()
        {
            Random r = new Random();
            return r.Next(100000, 1000000);
        }

        static bool IsUnique(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if (arr[i] == arr[j]) return false;
            return true;
        }
        static void Main(string[] args)
        {
            int[] otps = new int[10];
            for (int i = 0; i < 10; i++)
                otps[i] = GenerateOTP();

            Console.WriteLine(IsUnique(otps) ? "All OTPs Unique" : "Duplicates Found");
        }
    }
}
