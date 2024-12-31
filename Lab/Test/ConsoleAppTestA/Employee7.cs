using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleAppTest
{
    abstract class Employee7
    {
        public string name { get; set; }
        public int employeeID { get; set; }
        public abstract void CalculateSalary(int hoursWorked, double hourlyRate);
        public abstract void DisplayEmployeeDetails();
    }
    class FullTimeEmployee : Employee7
    {
        public double salary { get; set; }
        public override void CalculateSalary(int hoursWorked, double hourlyRate)
        {
            salary = hoursWorked * hourlyRate;
        }
        public override void DisplayEmployeeDetails()
        {
            Console.WriteLine("Employee ID: " + employeeID);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Salary: " + salary);
        }

    }
}
