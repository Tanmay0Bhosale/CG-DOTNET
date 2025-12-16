using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Input_Fee___Discount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Fee: ");
            double fee = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Discount Percentage: ");
            double discountPercent = Convert.ToDouble(Console.ReadLine());

            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;

            Console.WriteLine("The discount amount is INR " + discount +
                              " and final discounted fee is INR " + finalFee);
        }
    }
}
