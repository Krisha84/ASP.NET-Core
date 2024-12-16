using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class RBI
    {
        public virtual void calculateInterest()
        {
            Console.WriteLine("Calculation by RBI !!");
        }
    }

    class HDFC : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculation by HDFC !!");
        }
    }

    class SBI : RBI 
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculation by SBI !!");
        }
    }

    class ICICI : RBI
    {
        public override void calculateInterest()
        {
            Console.WriteLine("Calculation by ICICI !!");
        }
    }
}
