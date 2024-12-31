using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Vehicle
    {
        public string model { get; set; }
        public string brand { get; set; }
        public int speed { get; set; }

        public virtual void DisplayVehicle()
        {
            Console.WriteLine("- - Details - -");
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("Speed : " + speed);
        }
    }

    class Car : Vehicle 
    {
        public string fuelType { get; set; }

        public Car(string model, string brand, int speed, string fuelType)
        {
            this.model = model;
            this.brand = brand;
            this.speed = speed;
            this.fuelType = fuelType;
        }

        public override void DisplayVehicle()
        {
            Console.WriteLine("");
            Console.WriteLine("- - Car - -");
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("FuelType : " + fuelType);
        }
    }

    class Bike : Vehicle
    {
        public string  wheelType { get; set; }

        public Bike(string model, string brand, int speed, string wheelType)
        {
            this.model = model;
            this.brand = brand;
            this.speed = speed;
            this.wheelType= wheelType;
        }

        public override void DisplayVehicle()
        {
            Console.WriteLine("");
            Console.WriteLine("- - Bike - -");
            Console.WriteLine("Model : " + model);
            Console.WriteLine("Brand : " + brand);
            Console.WriteLine("WheelType : " + wheelType);
        }
    }
}
