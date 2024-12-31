using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1 :
            //Console.WriteLine("Choose a conversion type:");
            //Console.WriteLine("1. Kilometers to Miles");
            //Console.WriteLine("2. Pounds to Kilograms");
            //Console.WriteLine("3. Liters to Gallons");

            //int choice = Convert.ToInt32(Console.ReadLine());
            //double value, convertedValue;

            //switch (choice)
            //{
            //    case 1:
            //        Console.Write("Enter distance in kilometers: ");
            //        value = Convert.ToDouble(Console.ReadLine());

            //        convertedValue = value * 0.621371;
            //        Console.WriteLine(value + " kilometers " + "=" + convertedValue + " miles.");
            //        break;

            //    case 2:
            //        Console.Write("Enter weight in pounds: ");
            //        value = Convert.ToDouble(Console.ReadLine());

            //        convertedValue = value * 0.453592;
            //        Console.WriteLine(value + " pounds " + "=" + convertedValue + " kilograms.");
            //        break;

            //    case 3:
            //        Console.Write("Enter volume in liters: ");
            //        value = Convert.ToDouble(Console.ReadLine());

            //        convertedValue = value * 0.264172;
            //        Console.WriteLine(value + " liters " + "=" + convertedValue + " gallons.");
            //        break;

            //    default:
            //        Console.WriteLine("Oops !! Invalid Choice...");
            //        break;
            //}




            // Program-2 :
            //try
            //{
            //    Console.Write("Enter the first string: ");
            //    string s1 = Console.ReadLine();

            //    Console.Write("Enter the second string: ");
            //    string s2 = Console.ReadLine();

            //    Console.WriteLine("Are the two strings equal? " + s1.Equals(s2));

            //    Console.WriteLine("Concatenated String: " + string.Concat(s1, s2));

            //    Console.WriteLine("First string in uppercase: " + s1.ToUpper());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Exception : " + e.Message);
            //}




            // Program-3 :
            //Calculator calculator = new Calculator();

            //int intResult = calculator.Multiply(4, 5);
            //Console.WriteLine("Multiplication of integers: " + intResult);

            //double doubleResult = calculator.Multiply(4.5, 5.5);
            //Console.WriteLine($"Multiplication of doubles: " + doubleResult);

            //float floatResult = calculator.Multiply(4.5f, 5.5f);
            //Console.WriteLine($"Multiplication of floats: " + floatResult);




            // Program-4 :
            //Employee employee = new Employee();

            //employee.GetEmployeeDetails();

            //employee.DisplayEmployeeDetails();





            // Program-5 : 
            //Employee5 employee = new Employee5
            // {
            //     name = "Alice",
            //     age = 30,
            //     employeeID = 12345,
            //     salary = 50000
            //};

            //Manager manager = new Manager
            //{
            //    name = "Bob",
            //    age = 40,
            //    department = "IT"
            //};

            //employee.DisplayDetails();

            //manager.DisplayDetails();





            // Program-6 :
            //Car car = new Car("Model S", "Tesla", 200, "Electric");

            //Bike bike = new Bike("Ninja ZX-10R", "Kawasaki", 300, "Sport");

            //car.DisplayVehicle();

            //Console.WriteLine();

            //bike.DisplayVehicle();





            // Program-7 :
            //FullTimeEmployee employee = new FullTimeEmployee
            //{
            //    employeeID = 101,
            //    name = "John Doe"
            //};
           
            //int hoursWorked = 160; 
            //double hourlyRate = 50; 

            //employee.CalculateSalary(hoursWorked, hourlyRate);

            //employee.DisplayEmployeeDetails();
        }
    }
}
