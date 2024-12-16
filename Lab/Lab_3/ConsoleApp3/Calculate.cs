using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp3;

namespace ConsoleApp3
{
    internal interface Calc
    {
        void Addition(int a, int b);

        void Substraction(int x, int y);
    }

    class Result : Calc
    {
        public void Addition(int a,int b)
        {
            Console.WriteLine("Addition : " + (a + b));
        }

        public void Substraction(int x, int y) {
            Console.WriteLine("Substraction : " + (x - y));
        }
    }
}
