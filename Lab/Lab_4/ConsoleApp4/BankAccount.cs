using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class BankAccount
    {
        public double initialBalance;
        public String accountHolderName;
        public BankAccount(double initialBalance, String accountHolderName) 
        { 
            this.initialBalance = initialBalance;
            this.accountHolderName = accountHolderName;
        }
        public void Deposite()
        {
            Console.WriteLine("Deposite...!");
        }

        public void Withdraw()
        {
            Console.WriteLine("Withdraw...!");
        }

        public void Deposite(String type)
        {
            Console.WriteLine("Deposite by..."+ type);
        }

        public void Withdraw(String type)
        {
            Console.WriteLine("Withdraw by..."+ type);
        }
    }
}
