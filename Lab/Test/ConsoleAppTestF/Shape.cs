using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestF
{
    abstract class Shape
    {
        public string Name;
        public string Dimensions;
        public abstract double CalculateArea();
    }

    class Circle : Shape
    {
        public double Radius;
        public Circle(double radius)
        {
            Name = "Circle";
            Radius = radius;
            Dimensions = "Radius : " + radius;
        }
        public override double CalculateArea()
        {
            return (Math.PI * Radius * Radius);
        }
    }

    class Rectangle : Shape
    {
        public double Length;
        public double Width;
        public Rectangle(double length, double width)
        {
            Name = "Rectangle";
            Length = length;
            Width = width;
            Dimensions = "Lengthn: " + length + ", Width : " + width;
        }

        public override double CalculateArea()
        {
            return (Length * Width);
        }
    }
}
