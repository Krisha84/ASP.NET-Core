using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{


    using System;

    public class Account_Details
    {
        public int Account_Number;
        public string AC_Holder_Name;
        public double Account_Balance;

        public Account_Details(int accNo, string holderName, double accBalance)
        {
            Account_Number = accNo;
            AC_Holder_Name = holderName;
            Account_Balance = accBalance;
        }
    }

    public class Interest
    {
        public int Account_Number;
        public string AC_Holder_Name;
        public double Account_Balance;
        public double Interest_Rate;
        public double Time;

        public Interest(int accNo, string holderName, double accBalance, double interestRate, double timePeriod)
        {
            this.Account_Number = accNo;
            this.AC_Holder_Name = holderName;
            this.Account_Balance = accBalance;
            this.Interest_Rate = interestRate;
            this.Time = timePeriod;
        }

        public void Calculate_Interest()
        {
            double simpleInterest = (Account_Balance * Interest_Rate * Time) / 100;
            Console.WriteLine("Account Number: " + Account_Number);
            Console.WriteLine("Account Holder Name: " + AC_Holder_Name);
            Console.WriteLine("Account Balance: " + Account_Balance);
            Console.WriteLine("Interest Rate: " + Interest_Rate + "%");
            Console.WriteLine("Time Period: " + Time + " years");
            Console.WriteLine("Total Interest: " + simpleInterest);
        }
    }
}
