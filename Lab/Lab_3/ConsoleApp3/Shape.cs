using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal interface Shape
    {
        void Circle(double r);   
        void Triangle(double b, double h); 
        void Square(double l);
    }

    class Geometry : Shape
    {
        public void Circle(double r)
        {
            Console.WriteLine("Area of circle : "+ (Math.PI * r * r));
        }

        public void Triangle(double b, double h)
        {
            Console.WriteLine("Area of triangle : "+  (0.5 * b * h));
        }

        public void Square(double l)
        {
            Console.WriteLine("Area of square : "+ (l * l));
        }
    }
}
