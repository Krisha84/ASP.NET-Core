using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Staff
    {
        public string name;
        public string department;
        public string designation;
        public double experience;
        public double salary;

        public void getDetails()
        {
            Console.WriteLine("Enter your details : ");
                Console.WriteLine("-----");
                Console.WriteLine("Enter your name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter your department name : ");
                department = Console.ReadLine();
                Console.WriteLine("Enter designation : ");
                designation = Console.ReadLine().ToUpper();
                Console.WriteLine("Enter your experience : ");
                experience = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter your salary : ");
                salary = Convert.ToDouble(Console.ReadLine());
        }

        public void displayDetails()
        {
            if (designation.Equals("HOD"))
            {
                Console.WriteLine("Name : " + name);
                Console.WriteLine("Salary : " + salary);
            }
            else
            {
                Console.WriteLine("- - - -");
            }
        }

    }
}
