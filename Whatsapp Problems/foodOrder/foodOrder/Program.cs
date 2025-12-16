using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace foodOrder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Is restaurant open? (true/false): ");
            bool restaurantOpen = bool.Parse(Console.ReadLine());

            Console.Write("Is delivery partner available? (true/false): ");
            bool deliveryAvailable = bool.Parse(Console.ReadLine());

            Console.Write("Is customer Prime? (true/false): ");
            bool isPrimeCustomer = bool.Parse(Console.ReadLine());

            Console.Write("Enter order amount: ");
            int orderAmount = int.Parse(Console.ReadLine());

            if (!restaurantOpen || !deliveryAvailable)
            {
                Console.WriteLine("Order Rejected");
                return;
            }

            if (isPrimeCustomer || orderAmount >= 200)
                Console.WriteLine("Order Accepted");
            else
                Console.WriteLine("Order Rejected");
        }
    }
}
