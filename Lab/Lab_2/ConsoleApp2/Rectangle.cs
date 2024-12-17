using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Rectangle
    {
        public int Length;
        public int Width;

        public Rectangle(int length, int width)
        {
            Length = length;
            Width = width;
        }

        public int CalculateArea()
        {
            return (Length * Width);
        }
    }
}
