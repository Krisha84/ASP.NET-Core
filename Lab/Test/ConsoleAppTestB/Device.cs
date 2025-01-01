using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestB
{
    internal class Device
    {
        public int DeviceID { get; set; }
        public string DeviceName { get; set; }
        public int AverageLife { get; set; } 
        public string OSType { get; set; } 

        public virtual void GetDetails()
        {
            Console.Write("Enter Device ID : ");
            DeviceID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Device Name : ");
            DeviceName = Console.ReadLine();
            Console.Write("Enter Average Life (in years) : ");
            AverageLife = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter OS Type : ");
            OSType = Console.ReadLine();
        }
        
        public virtual void DisplayDetails()
        {
            Console.WriteLine("--Details--");
            Console.WriteLine("Device ID : " + DeviceID);
            Console.WriteLine("Device Name : " + DeviceName);
            Console.WriteLine("Average Life : " + AverageLife + "years");
            Console.WriteLine("OS Type : " + OSType);
        }
    }
    class Laptop : Device
    {
        public string ModelName { get; set; }
        public string LaptopType { get; set; } 

        public override void GetDetails()
        {
            base.GetDetails();
           
            Console.Write("Enter Model Name : ");
            ModelName = Console.ReadLine();

            Console.Write("Enter Laptop Type : ");
            LaptopType = Console.ReadLine();
        }

        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine("Model Name : " + ModelName);
            Console.WriteLine("Laptop Type : " + LaptopType);
        }
    }
}

