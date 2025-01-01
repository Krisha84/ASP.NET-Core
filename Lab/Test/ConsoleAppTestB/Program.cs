using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestB
{
    internal class Program
    {
        // For Program-7 :
        //static string DecimalToBinary(int n)
        //{
        //    if (n == 0)
        //    {
        //        return "";
        //    }

        //    return DecimalToBinary(n / 2) + (n % 2).ToString();
        //}

        static void Main(string[] args)
        {
            // Program - 1 :
            //int[] marks = new int[5];
            //int totalMarks = 0;
            //double percentage;
            //char grade;
            //Console.WriteLine("Enter marks for 5 subjects (out of 100):");

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Subject " + (i+1) + " : ");
            //    marks[i] = Convert.ToInt32(Console.ReadLine());

            //    if (marks[i] < 0 || marks[i] > 100)
            //    {
            //        Console.WriteLine("Oops !! Invalid Marks...");
            //        i--;
            //        continue;
            //    }
            //    totalMarks += marks[i];
            //}

            //percentage = Convert.ToDouble(totalMarks) / 5;

            //if (percentage >= 90)
            //{
            //    grade = 'A';
            //}
            //else if (percentage >= 80)
            //{
            //    grade = 'B';
            //}
            //else if (percentage >= 70)
            //{
            //    grade = 'C';
            //}
            //else if (percentage >= 60)
            //{
            //    grade = 'D';
            //}
            //else
            //{
            //    grade = 'F';
            //}

            //Console.WriteLine("--Results--");
            //Console.WriteLine("Total Marks : " + totalMarks);
            //Console.WriteLine("Percentage : " + percentage + "%");
            //Console.WriteLine("Grade : " + grade);





            // Program-2 :
            //Console.Write("Enter a number : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int org = n;
            //int rev = 0;

            //while (n > 0)
            //{
            //    int r = n % 10;
            //    rev = (rev * 10) + r;
            //    n /= 10;
            //}

            //if (org == rev)
            //{
            //    Console.WriteLine(org + " is a Palindrome !!");
            //}
            //else
            //{
            //    Console.WriteLine(org + " is not a Palindrome !!");
            //}





            // Program-3 :
            //Laptop myLaptop = new Laptop();

            //Console.WriteLine("Enter details of the Laptop :");
            //myLaptop.GetDetails();

            //Console.WriteLine("Displaying Laptop details:");
            //myLaptop.DisplayDetails();





            // Program-4 :
            //Dictionary<string, string> contacts = new Dictionary<string, string>();
            //bool running = true;

            //while (running)
            //{
            //    Console.WriteLine("PhoneBook Menu:");
            //    Console.WriteLine("1. Add Contact");
            //    Console.WriteLine("2. Display All Contacts");
            //    Console.WriteLine("3. Search Contact");
            //    Console.WriteLine("4. Delete Contact");
            //    Console.WriteLine("5. Exit");

            //    Console.Write("Enter your choice : ");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter Contact Name : ");
            //            string name = Console.ReadLine();
            //            Console.Write("Enter Contact Number : ");
            //            string number = Console.ReadLine();
            //            contacts[name] = number;
            //            break;

            //        case 2:
            //            if (contacts.Count == 0)
            //            {
            //                Console.WriteLine("PhoneBook is empty !!");
            //                break;
            //            }
            //            Console.WriteLine("PhoneBook Contacts:");
            //            foreach (var contact in contacts)
            //            {
            //                Console.WriteLine("Name: " + contact.Key + " , Number : " + contact.Value);
            //            }
            //            break;

            //        case 3:
            //            Console.Write("Enter Contact Name to Search : ");
            //            name = Console.ReadLine();

            //            if (contacts.ContainsKey(name))
            //            {
            //                Console.WriteLine("Contact Found - Name : " + name + " , Number : " + contacts[name]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact " + name + " not found !!");
            //            }
            //            break;

            //        case 4:
            //            Console.Write("Enter Contact Name to Delete: ");
            //            name = Console.ReadLine();

            //            if (contacts.Remove(name))
            //            {
            //                Console.WriteLine("Contact " + name + " deleted successfully !!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Contact " + name + " not found !!");
            //            }
            //            break;

            //        case 5:
            //            running = false;
            //            Console.WriteLine("Exiting PhoneBook !!");
            //            break;

            //        default:
            //            Console.WriteLine("Oops !! Invalid Choice...");
            //            break;
            //    }
            //}





            // Program-5 :
            //try
            //{
            //    Console.Write("Enter the first string : ");
            //    string s1 = Console.ReadLine().ToLower();

            //    Console.Write("Enter the second string : ");
            //    string s2 = Console.ReadLine().ToLower();

            //    if (!s1.Equals(s2))
            //    {
            //        throw new StringsNotEqualException("The two strings are not equal !!");
            //    }
            //    Console.WriteLine("The two strings are equal !!");
            //}
            //catch (StringsNotEqualException e)
            //{
            //    Console.WriteLine($"Exception: {e.Message}");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine($"Unexpected Error: {e.Message}");
            //}





            // Program-6 :
            //List<Project> projectList = new List<Project>();
            //bool running = true;

            //while (running)
            //{
            //    Console.WriteLine("Menu:");
            //    Console.WriteLine("1. Add a Project");
            //    Console.WriteLine("2. Display All Projects");
            //    Console.WriteLine("3. Remove a Project");
            //    Console.WriteLine("4. Exit");

            //    Console.Write("Enter your choice: ");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    switch (choice)
            //    {
            //        case 1: 
            //            Project newProject = new Project();
            //            Console.WriteLine("Enter details for the new project:");
            //            newProject.GetDetails();
            //            projectList.Add(newProject);
            //            break;

            //        case 2: 
            //            if (projectList.Count == 0)
            //            {
            //                Console.WriteLine("No projects to display !!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Projects in the List : ");
            //                foreach (var project in projectList)
            //                {
            //                    project.DisplayDetails();
            //                }
            //            }
            //            break;

            //        case 3: 
            //            Console.Write("Enter the No. of Project to remove : ");
            //            int index = Convert.ToInt32(Console.ReadLine());
            //            projectList.RemoveAt(index - 1);
            //            break;

            //        case 4:
            //            running = false;
            //            Console.WriteLine("Exiting program...Goodbye!");
            //            break;

            //        default:
            //            Console.WriteLine("Oops !! Invalid Choice...");
            //            break;
            //    }
            //}






            // Program-7 :
            //Console.Write("Enter a decimal number : ");
            //int dec = Convert.ToInt32(Console.ReadLine());
           
            //if (dec == 0)
            //{
            //    Console.WriteLine("Binary : 0");
            //}
            //else
            //{
            //    string binary = DecimalToBinary(dec);
            //    Console.WriteLine("Binary : " + binary);
            //}
        }
    }
}


