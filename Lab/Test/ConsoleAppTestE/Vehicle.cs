using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestE
{
    internal class Vehicle
    {
        public string Make;
        public string Model;
        public int Year;

        public void InputDetails()
        {
            Console.Write("Enter Make : ");
            Make = Console.ReadLine();
            Console.Write("Enter Model : ");
            Model = Console.ReadLine();
            Console.Write("Enter Year : ");
            Year = Convert.ToInt32(Console.ReadLine());
        }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("Make : " + Make);
            Console.WriteLine("Model : " + Model);
            Console.WriteLine("Year : " + Year);
        }
    }

    class Car : Vehicle
    {
        public string FuelType;
        public void InputCarDetails()
        {
            InputDetails();
            Console.Write("Enter Fuel Type (Petrol/Diesel/Electric) : ");
            FuelType = Console.ReadLine();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Fuel Type : " + FuelType);
        }
    }

    class Truck : Vehicle
    {
        public double LoadCapacity;
        public void InputTruckDetails()
        {
            InputDetails();
            Console.Write("Enter Load Capacity (in tons) : ");
            LoadCapacity = double.Parse(Console.ReadLine());
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Load Capacity : " + LoadCapacity + " tons");
        }
    }
}
