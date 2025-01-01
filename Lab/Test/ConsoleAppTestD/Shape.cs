using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestD
{
    internal class Shape
    {
        public double Area(double radius) => Math.PI * radius * radius;
        public double Area(double length, double width) => length * width;
        public double Area(float baseLength, float height) => 0.5 * baseLength * height;
    }
}
