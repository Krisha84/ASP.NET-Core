using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1 :
            //Product product = new Product(101, "Laptop", 75000.50m);
            //product.DisplayProductDetails();



            // Program-2:
            //BankTransaction transaction = new BankTransaction();

            //transaction.Deposit(500);
            //transaction.DisplayBalance();

            //transaction.Deposit(1000, 12345);
            //transaction.DisplayBalance();

            //transaction.Deposit(1500, "1234567890123456");
            //transaction.DisplayBalance();




            // Program-3 :
            //Vehicle myCar = new Car();

            //myCar.Start();
            //myCar.Stop();




            // Program-4 :
            //Dictionary<string, string> studentGrades = new Dictionary<string, string>();
            //bool exit = false;

            //while (!exit)
            //{
            //    Console.WriteLine("Student Grade Management System");
            //    Console.WriteLine("1. Add a Student and Grade");
            //    Console.WriteLine("2. Remove a Student by Name");
            //    Console.WriteLine("3. Check if a Student Exists");
            //    Console.WriteLine("4. Display All Students");
            //    Console.WriteLine("5. Exit");

            //    Console.Write("Choose an option : ");
            //    int choice = Convert.ToInt32(Console.ReadLine());

            //    if (choice <= 0 || choice > 5)
            //    {
            //        Console.WriteLine("Oops !! Invalid Input...");
            //        continue;
            //    }

            //    switch (choice)
            //    {
            //        case 1:
            //            Console.Write("Enter student's name : ");
            //            string studentName = Console.ReadLine();
            //            Console.Write("Enter student's grade : ");
            //            string grade = Console.ReadLine();

            //            if (!studentGrades.ContainsKey(studentName))
            //            {
            //                studentGrades.Add(studentName, grade);
            //                Console.WriteLine("Student " + studentName + " with grade " + grade + " added !!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("This student already exists in the dictionary !!");
            //            }
            //            break;

            //        case 2:
            //            Console.Write("Enter the name of the student to remove : ");
            //            string removeName = Console.ReadLine();

            //            if (studentGrades.Remove(removeName))
            //            {
            //                Console.WriteLine("Student " + removeName + " has been removed !!");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Student not found !!");
            //            }
            //            break;

            //        case 3:
            //            Console.Write("Enter student's name to check : ");
            //            string checkName = Console.ReadLine();

            //            if (studentGrades.ContainsKey(checkName))
            //            {
            //                Console.WriteLine("Student " + checkName + " exists with grade : " + studentGrades[checkName]);
            //            }
            //            else
            //            {
            //                Console.WriteLine("Student not found !!");
            //            }
            //            break;

            //        case 4:
            //            Console.WriteLine("List of All Students:");
            //            foreach (var student in studentGrades)
            //            {
            //                Console.WriteLine(student.Key + " : " + student.Value);
            //            }
            //            break;

            //        case 5:
            //            exit = true;
            //            Console.WriteLine("Exiting the program !!");
            //            break;

            //        default:
            //            Console.WriteLine("Oops !! Invalid Choice...");
            //            break;
            //    }
            //}





            // Program-5 :
            //Console.Write("Enter the dimension of the square matrix (n x n) : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int[,] matrix = new int[n, n];

            //Console.WriteLine("Enter the elements of the matrix : ");
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        Console.Write("Element at position " + (i + 1) + " , " + (j + 1) + " : ");
            //        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}

            //int diagonalSum = CalculateDiagonalSum(matrix, n);

            //Console.WriteLine("The sum of the diagonal elements is : " + diagonalSum);





            // Program-6 :
            //Console.Write("Enter the first string: ");
            //string s1 = Console.ReadLine().ToLower(); 

            //Console.Write("Enter the second string: ");
            //string s2 = Console.ReadLine().ToLower(); 

            //bool isAnagram = AreAnagrams(s1, s2);

            //if (isAnagram)
            //{
            //    Console.WriteLine("'" + s1 + "' and '" + s2 + "' are anagrams !!");
            //}
            //else
            //{
            //    Console.WriteLine("'" + s1 + "' and '" + s2 + "' are not anagrams !!");
            //}




            // Program-7 :
            //Console.Write("Enter a number: ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //if (IsArmstrong(n))
            //{
            //    Console.WriteLine(n + " is an Armstrong number !!");
            //}
            //else
            //{
            //    Console.WriteLine(n + " is not an Armstrong number !!");
            //}

        }


        // For Program-5 :
        //public static int CalculateDiagonalSum(int[,] matrix, int size)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < size; i++)
        //    {
        //        sum += matrix[i, i]; 
        //    }
        //    return sum;
        //}



        // For Program-6 :
        //public static bool AreAnagrams(string s1, string s2)
        //{
        //    if (s1.Length != s2.Length)
        //    {
        //        return false;
        //    }

        //    char[] arr1 = s1.ToCharArray();
        //    char[] arr2 = s2.ToCharArray();

        //    Array.Sort(arr1);
        //    Array.Sort(arr2);

        //    for (int i = 0; i < arr1.Length; i++)
        //    {
        //        if (arr1[i] != arr2[i])
        //        {
        //            return false;
        //        }
        //    }
        //    return true;
        //}



        // For Program-7 :
        //public static bool IsArmstrong(int n)
        //{
        //    int org = n;
        //    int sum = 0;
        //    int digits = n.ToString().Length;

        //    while (n > 0)
        //    {
        //        int digit = n % 10; 
        //        sum += (int)Math.Pow(digit, digits); 
        //        n /= 10; 
        //    }
        //    return sum == org;
        //}
    }
}
