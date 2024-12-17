using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Distance
    {
        public double Dist1;
        public double Dist2;
        public double Dist3;

        public Distance(double dist1, double dist2)
        {
            this.Dist1 = dist1;
            this.Dist2 = dist2;
        }

        public void CalculateTotalDistance()
        {
            Dist3 = Dist1 + Dist2;
        }

        public void DisplayDistance()
        {
            Console.WriteLine("Distance 1: " + Dist1);
            Console.WriteLine("Distance 2: " + Dist2);
            Console.WriteLine("Total Distance: " + Dist3);
        }
    }
}
