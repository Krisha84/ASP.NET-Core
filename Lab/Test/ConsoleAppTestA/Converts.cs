using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Converts
    {
        public double km;
        public double pounds;
        public double liters;

        public void kmToMiles(double km)
        {
            Console.WriteLine("Miles : " + (km * 0.621371));
        }

        public void poundsToKg(double pounds)
        {
            Console.WriteLine("Kilograms : " + (pounds * 0.453592));
        }

        public void litersToGallons(double liters)
        {
            Console.WriteLine("Gallons : " + (liters * .264172));
        }
    }
}
