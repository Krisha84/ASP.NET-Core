using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestE
{
    internal class Student
    {
        public int RollNumber;
        public string Name;
        public int[] Marks = new int[5];
        public void InputDetails()
        {
            Console.Write("Enter Roll Number : ");
            RollNumber = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name : ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Marks for 5 Subjects :");
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write("Subject " + (i + 1) + ": ");
                Marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Student Details:");
            Console.WriteLine("Roll Number : " + RollNumber);
            Console.WriteLine("Name : " + Name);
            Console.WriteLine("Marks :");
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.WriteLine("Subject " + (i + 1) + ":" + Marks[i]);
            }
        }

        public int CalculateTotalMarks()
        {
            int total = 0;
            foreach (int mark in Marks)
            {
                total += mark;
            }
            return total;
        }

        public double CalculatePercentage()
        {
            int totalMarks = CalculateTotalMarks();
            return ((double)totalMarks / (Marks.Length * 100) * 100);
        }

        public string DetermineGrade()
        {
            double percentage = CalculatePercentage();
            if (percentage >= 90)
            {
                return "A";
            }
            else if (percentage >= 75)
            {
                return "B";
            }
            else if (percentage >= 50)
            {
                return "C";
            }
            else
            {
                return "F";
            }
        }
    }
}
