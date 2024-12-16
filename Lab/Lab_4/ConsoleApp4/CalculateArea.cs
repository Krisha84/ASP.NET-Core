using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class CalculateArea
    {
        public void CalArea(int l)
        {
            Console.WriteLine("Area of Square : "+ (l*l));  
        }

        public void CalArea(double h, double w) 
        { 
            Console.WriteLine("Area of Rectangle : "+ (h*w));
        }

        public void CalArea(double r)
        {
            Console.WriteLine("Area of Circle : "+ (Math.PI*r*r));
        }
    }
}
