using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestE
{
    abstract class Employee
    {
        public string Name;
        public int EmployeeID;
        public abstract double CalculateSalary();
    }

    interface IBonus
    {
        double CalculateBonus();
    }

    class Manager : Employee, IBonus
    {
        public double BaseSalary;
        public double Allowances;

        public override double CalculateSalary()
        {
            return BaseSalary + Allowances;
        }

        public double CalculateBonus()
        {
            return (BaseSalary * 0.10);
        }
    }

    class Worker : Employee, IBonus
    {
        public double HourlyRate;
        public int HoursWorked;

        public override double CalculateSalary()
        {
            return (HourlyRate * HoursWorked);
        }

        public double CalculateBonus()
        {
            return (HourlyRate * 20);
        }
    }
}
