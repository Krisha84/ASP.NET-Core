using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1 :
            //Console.Write("Enter the starting value of the range : ");
            //int start = Convert.ToInt32(Console.ReadLine());

            //Console.Write("Enter the ending value of the range: ");
            //int end = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Prime numbers between " + start + " and " + end + " are :");
            //for (int i = start; i <= end; i++)
            //{
            //    if (IsPrime(i))
            //    {
            //        Console.Write(i + " ");
            //    }
            //}




            // Program-2 :
            //Student student = new Student();

            //student.InputDetails();
            //student.DisplayDetails();

            //int totalMarks = student.CalculateTotalMarks();
            //Console.WriteLine("Total Marks : " + totalMarks);

            //double percentage = student.CalculatePercentage();
            //Console.WriteLine("Percentage : " + percentage + "%");

            //string grade = student.DetermineGrade();
            //Console.WriteLine("Grade : " + grade);





            // Program-3 :
            //Car car = new Car();

            //Console.WriteLine("Enter details for Car :");
            //car.InputCarDetails();

            //Console.WriteLine("Car Details:");
            //car.DisplayDetails();

            //Console.WriteLine("-------------------------");

            //Truck truck = new Truck();

            //Console.WriteLine("Enter details for Truck:");
            //truck.InputTruckDetails();

            //Console.WriteLine("Truck Details:");
            //truck.DisplayDetails();





            // Program-4 :
            //Console.WriteLine("Enter details for Manager :");
            //Manager manager = new Manager
            //{
            //    Name = "Alice",
            //    EmployeeID = 101,
            //    BaseSalary = 50000,
            //    Allowances = 20000
            //};

            //Console.WriteLine("Manager " + manager.Name + " (ID:" + manager.EmployeeID + ") : ");
            //Console.WriteLine("Salary : " + manager.CalculateSalary());
            //Console.WriteLine("Bonus : " + manager.CalculateBonus());

            //Console.WriteLine("----------------------");

            //Console.WriteLine("Enter details for Worker :");
            //Worker worker = new Worker
            //{
            //    Name = "Bob",
            //    EmployeeID = 202,
            //    HourlyRate = 50,
            //    HoursWorked = 160
            //};

            //Console.WriteLine("Worker " + worker.Name + " (ID:" + worker.EmployeeID + ") : ");
            //Console.WriteLine("Salary: " + worker.CalculateSalary());
            //Console.WriteLine("Bonus : " + worker.CalculateBonus());




            // Program-5 :
            //try
            //{
            //    Console.Write("Enter your age: ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    if (age < 0)
            //    {
            //        throw new NegativeAgeException("Age cannot be negative !!");
            //    }
            //    Console.WriteLine("Your age is : " + age);
            //}
            //catch (NegativeAgeException e)
            //{
            //    Console.WriteLine($"Error : {e.Message}");
            //}





            // Program-6 :
            //Console.Write("Enter a string : ");
            //string s1 = Console.ReadLine();

            //int vowels = 0;
            //int consonants = 0;
            //int digits = 0;
            //int specialCharacters = 0;

            //foreach (char ch in s1)
            //{
            //    if (char.IsDigit(ch))
            //    {
            //        digits++;
            //    }
            //    else if (char.IsLetter(ch))
            //    {
            //        char lowerChar = char.ToLower(ch);
            //        if ("aeiou".Contains(lowerChar))
            //        {
            //            vowels++;
            //        }
            //        else
            //        {
            //            consonants++;
            //        }
            //    }
            //    else if (!char.IsWhiteSpace(ch))
            //    {
            //        specialCharacters++;
            //    }
            //}

            //Console.WriteLine("Vowels : " + vowels);
            //Console.WriteLine("Consonants : " + consonants);
            //Console.WriteLine("Digits : " + digits);
            //Console.WriteLine("Special Characters : " + specialCharacters);




            // Program-7 :
            //Time time1 = new Time(1, 45, 50);

            //Console.WriteLine("Original Time:");
            //time1.Display();

            //Time timeCopy = new Time(time1);

            //Console.WriteLine("Copied Time:");
            //timeCopy.Display();

            //Time time2 = new Time(2, 20, 30);

            //Console.WriteLine("Another Time:");
            //time2.Display();

            //Time timeSum = time1.Add(time2);

            //Console.WriteLine("Sum of Times:");
            //timeSum.Display();
        }


        // For Program-1 :
        //static bool IsPrime(int n)
        //{
        //    if (n <= 1)
        //    {
        //        return false;
        //    }
        //    for (int i = 2; i <= Math.Sqrt(n); i++)
        //    {
        //        if (n % i == 0)
        //            return false;
        //    }
        //    return true;
        //}
    }
}
