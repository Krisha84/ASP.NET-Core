using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student
    {
        public int RollNo;
        public string Name;
        public int[] Marks = new int[5];

        public void InputDetails()
        {
            Console.Write("Enter Roll Number: ");
            RollNo = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Enter marks for 5 subjects:");
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write($"Subject {i + 1}: ");
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("\nStudent Details:");
            Console.WriteLine("Roll Number: " + RollNo);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Marks: " + string.Join(", ", Marks));
            Console.WriteLine("Total Marks: " + CalculateTotalMarks());
            Console.WriteLine("Percentage: " + CalculatePercentage() + "%");
            Console.WriteLine("Grade: " + DetermineGrade());
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
            return (totalMarks / 500.0) * 100;
        }

        public string DetermineGrade()
        {
            double percentage = CalculatePercentage();
            if (percentage >= 90)
                return "A";
            else if (percentage >= 75)
                return "B";
            else if (percentage >= 50)
                return "C";
            else
                return "F";
        }
    }
}

