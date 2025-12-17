using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace courseFee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double fee = 125000;
            double discountPercent = 10;

            double discount = fee * discountPercent / 100;
            double finalFee = fee - discount;

            Console.WriteLine("The discount amount is INR " + discount +
                              " and final discounted fee is INR " + finalFee);
        }
    }
}
