using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace profit_and_profit_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int costPrice = 129;
            int sellingPrice = 191;

            int profit = sellingPrice - costPrice;
            double profitPercent = (profit * 100.0) / costPrice;

            Console.WriteLine(
                "The Cost Price is INR " + costPrice + " and Selling Price is INR " + sellingPrice +
                "\nThe Profit is INR " + profit + " and the Profit Percentage is " + profitPercent);
        }
    }
}
