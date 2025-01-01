using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestB
{
    internal class Project
    {
        public string ProjectName { get; set; }
        public int LineOfCode { get; set; }
        public string FrontendTechnology { get; set; }
        public string BackendTechnology { get; set; }
        
        public void GetDetails()
        {
            Console.Write("Enter Project Name: ");
            ProjectName = Console.ReadLine();
            Console.Write("Enter Line of Code: ");
            LineOfCode = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Frontend Technology: ");
            FrontendTechnology = Console.ReadLine();
            Console.Write("Enter Backend Technology: ");
            BackendTechnology = Console.ReadLine();
        }
   
        public void DisplayDetails()
        {
            Console.WriteLine("Project Name : " + ProjectName);
            Console.WriteLine("Line of Code : " + LineOfCode);
            Console.WriteLine("Frontend Technology : " + FrontendTechnology);
            Console.WriteLine("Backend Technology : " + BackendTechnology);
        }

    }
}
