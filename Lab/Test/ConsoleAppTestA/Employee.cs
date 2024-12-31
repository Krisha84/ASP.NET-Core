using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppTest
{
    internal class Employee
    {
        public string name;
        public int ID;
        public string position;
        public double salary;

        public void GetEmployeeDetails()
        {
            Console.WriteLine("Enter the name : ");
            name = Console.ReadLine();
            Console.WriteLine("Enter the employee Id : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter position : ");
            position = Console.ReadLine();
            Console.WriteLine("Enter the salary : ");
            salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("- - Details - -");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("ID : " + ID);
            Console.WriteLine("Position : " + position);
            Console.WriteLine("Salary : " + salary);
        }
    }
}
