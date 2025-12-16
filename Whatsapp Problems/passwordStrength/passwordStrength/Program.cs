using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passwordStrength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            bool hasLength = password.Length >= 8;
            bool hasDigit = false;
            bool hasSpecial = false;

            foreach (char ch in password)
            {
                if (char.IsDigit(ch))
                    hasDigit = true;
                else if (!char.IsLetterOrDigit(ch))
                    hasSpecial = true;
            }

            int strength = 0;
            if (hasLength) strength++;
            if (hasDigit) strength++;
            if (hasSpecial) strength++;

            if (strength == 3)
                Console.WriteLine("Strong");
            else if (strength == 2)
                Console.WriteLine("Medium");
            else
                Console.WriteLine("Weak");
        }
    }
}
