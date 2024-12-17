using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    interface Gross
    {
        double Gross_sal();
    }

    public class Salary10 : Gross
    {
        public double HRA;
        public double TA;
        public double DA;

        public Salary10(double hra, double ta, double da)
        {
            this.HRA = hra;
            this.TA = ta;
            this.DA = da;
        }

        public double Gross_sal()
        {
            return (HRA + TA + DA);
        }

        public void Disp_sal()
        {
            Console.WriteLine("Gross Salary: " + Gross_sal());
        }
    }

    public class Employee : Salary10
    {
        public string Name;

        public Employee(string name, double hra, double ta, double da) : base(hra, ta, da)
        {
            this.Name = name;
        }

        public double basic_sal()
        {
            return (10000); 
        }
    }
}
