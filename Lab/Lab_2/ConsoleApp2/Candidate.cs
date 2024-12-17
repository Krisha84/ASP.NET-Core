using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Candidate
    {
        public int id;
        public string name;
        public int age;
        public double weight;
        public double height;
        public void GetCandidateDetails()
        {
            Console.WriteLine("Enter your id : ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your name : ");
            name =   Console.ReadLine();
            Console.WriteLine("Enter your age : ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your weight : ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter your height : ");
            height = Convert.ToDouble(Console.ReadLine());
        }

        public void DisplayCandidateDetails()
        {
            Console.WriteLine("- - Details - -");
            Console.WriteLine("ID : " + id);
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Age : " + age);  
            Console.WriteLine("Weight : " + weight);
            Console.WriteLine("Height : " + height);
        }
    }
}
