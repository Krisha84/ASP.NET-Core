using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Salary
    {
        public double Basic;
        public double TA;
        public double DA = 0.10; 
        public double HRA = 0.05; 

        public Salary(double basic, double ta)
        {
            this.Basic = basic;
            this.TA = ta;
        }

        public double CalculateSalary()
        {
            double grossSalary = Basic + TA + (Basic * DA) + (Basic * HRA);
            return grossSalary;
        }
    }
}
