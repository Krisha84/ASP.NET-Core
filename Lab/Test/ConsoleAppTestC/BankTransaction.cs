using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestC
{
    internal class BankTransaction
    {
        public double Balance = 0;
        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Oops !!Invalid amount...Deposit failed");
                return;
            }
            Balance += amount;
            Console.WriteLine("Deposited " + amount + " in cash. New balance : " + Balance);
        }
  
        public void Deposit(double amount, int chequeNo)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Oops !! Invalid amount...Deposit failed");
                return;
            }
            if (chequeNo <= 0)
            {
                Console.WriteLine("Invalid cheque number. Deposit failed.");
                return;
            }
            Balance += amount;
            Console.WriteLine("Deposited " + amount + " using cheque " + chequeNo + ". New balance : " + Balance);
        }
        
        public void Deposit(double amount, string cardNo)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Oops !! Invalid amount...Deposit failed");
                return;
            }

            if (string.IsNullOrWhiteSpace(cardNo) || cardNo.Length < 4)
            {
                Console.WriteLine("Oops !! Invalid card number...Deposit failed");
                return;
            }
            Balance += amount;
            Console.WriteLine("Deposited " + amount + " using card ending in " + cardNo + ". New balance : " + Balance);
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Current Balance : " + Balance);
        }
    }
}
