using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Area
    {
        public void findArea(int l)
        {
            Console.WriteLine("Area of square : " + (l * l));
        }

        public void findArea(int h, int w) 
        { 
            Console.WriteLine("Area of ractangle : "+ (h*w));
        }
    }
}
