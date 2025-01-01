using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestF
{
    internal class Employee
    {
        public int EmployeeID;
        public string Name;
        public double Salary;

        public void InputDetails()
        {
            Console.Write("Enter Employee ID : ");
            EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Employee Name : ");
            Name = Console.ReadLine();
            Console.Write("Enter salary : ");
            Salary = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Employee ID : " + EmployeeID + " , Name : " + Name);
        }
        public double CalculateAnnualSalary()
        {
            double totalSalary = Salary * 12;
            return totalSalary;
        }
        public void DeterminePerformance()
        {
            double annualSalary = CalculateAnnualSalary();
            Console.WriteLine("Annual Salary: " + annualSalary);

            if (annualSalary > 1000000)
            {
                Console.WriteLine("Performance: Outstanding");
            }
            else if (annualSalary >= 500000)
            {
                Console.WriteLine("Performance: Excellent");
            }
            else if (annualSalary >= 250000)
            {
                Console.WriteLine("Performance: Good");
            }
            else
            {
                Console.WriteLine("Performance: Needs Improvement");
            }
        }
    }
}
