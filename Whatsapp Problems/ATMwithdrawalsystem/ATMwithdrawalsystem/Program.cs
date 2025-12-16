using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMwithdrawalsystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dailyLimit = 1000;
            int balance = 20000;

            Console.WriteLine("Enter the amount to withdraw:");
            int amount = Convert.ToInt32(Console.ReadLine());

            if(amount <= dailyLimit && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawal successful! New balance: {balance}");
            }
            else if(amount > dailyLimit)
            {
                Console.WriteLine("Withdrawal amount exceeds daily limit.");
            }
            else
            {
                Console.WriteLine("Insufficient balance.");
            }
        }
    }
}
