using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Sum
    {
        public abstract void SumOfTwo(int a, int b); 

        public abstract void SumOfThree(int x,int y,int z);
    }

    class Calculate : Sum
    {
        public override void SumOfTwo(int a , int b)
        {
            Console.WriteLine("Sum of Two number : "+ (a+b));
        }

        public override void SumOfThree(int x, int y, int z)
        {
            Console.WriteLine("Sum of three number : "+ (x+y+z));
        }
    }
}