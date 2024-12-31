using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public virtual void DisplayDetails()
        {
            Console.WriteLine("- - Details - -");
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);
        }
    }

    class Employee5 : Person
    {
        public int employeeID { get; set; }
        public int salary { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("- - Employee - -");
            Console.WriteLine("Employee Name : " + name);
            Console.WriteLine("Employee Age : " + age);
            Console.WriteLine("Employee Id : " + employeeID);
            Console.WriteLine("Employee Salary : " + salary);
        }
    }

    class Manager : Person
    {
        public string department { get; set; }

        public override void DisplayDetails()
        {
            Console.WriteLine("");
            Console.WriteLine("- - Manager - -");
            Console.WriteLine("Manager Name : " + name);
            Console.WriteLine("Manager Age : " + age);
            Console.WriteLine("Manager Department : " + department);
        }       
    }
}
