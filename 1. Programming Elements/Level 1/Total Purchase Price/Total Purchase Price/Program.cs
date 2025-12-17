using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Total_Purchase_Price
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter unit price: ");
            double unitPrice = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double totalPrice = unitPrice * quantity;

            Console.WriteLine("The total purchase price is INR " + totalPrice +
                              " if the quantity " + quantity +
                              " and unit price is INR " + unitPrice);
        }
    }
}
