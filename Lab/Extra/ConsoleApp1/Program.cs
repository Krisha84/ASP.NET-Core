using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter choice for execute program : ");
            int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1: // Program-1 :
                            Console.WriteLine("Enter the starting point : ");
                            int s = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the ending point : ");
                            int e = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("--Prime_Numbers--");
                            for (int i = s; i <= e; i++)
                            {
                                int count = 0;

                                for (int j = 1; j <= i; j++)
                                {
                                    if (i % j == 0)
                                    {
                                        count++;
                                    }
                                }

                                if (count == 2)
                                {
                                    Console.WriteLine(i);
                                }
                            }
                            break;

                    case 2: // Program-2 :
                            Student student = new Student();

                            student.InputDetails();

                            student.DisplayDetails();
                            break;

                    case 7: // Program-7 :
                            Time t1 = new Time(2, 45, 50);
                            Console.WriteLine("Original Time t1:");
                            t1.Display();

                            Console.WriteLine("");

                            Time t2 = new Time(t1);
                            Console.WriteLine("Copied Time t2:");
                            t2.Display();

                            Console.WriteLine("");

                            Time t3 = new Time(3, 20, 40);
                            Console.WriteLine("Another Time t3:");
                            t3.Display();

                            Console.WriteLine("");

                            t1.AddTime(t3);
                            Console.WriteLine("After Adding t3 to t1:");
                            t1.Display();
                            break;

                    case 8: // Program-8 :
                            // Write a program to determine if two given strings are anagrams to each other.
                            // for example 'listen' ans 'silent' are anagrams but 'hello' and 'world' are not.

                            Console.WriteLine("Enter a string 1 : ");
                            string str1 = Console.ReadLine();
                            Console.WriteLine("Enter a string 2 : ");
                            string str2 = Console.ReadLine();

                            Console.WriteLine();

                            if (str1.Length != str2.Length)
                            {
                                Console.WriteLine(str1 + " and " + str2 + " are not anagrams !!");
                            }

                            else
                            {
                                char[] arr1 = str1.ToCharArray();
                                char[] arr2 = str2.ToCharArray();

                                Array.Sort(arr1);
                                Array.Sort(arr2);

                                bool isAnagram = true;

                                for (int i = 0; i < arr1.Length; i++)
                                {
                                    if (arr1[i] != arr2[i])
                                    {
                                        isAnagram = false;
                                        break;
                                    }
                                }

                                if (isAnagram)
                                {
                                    Console.WriteLine(str1 + " and " + str2 + " are anagrams !!");
                                }
                                else
                                {
                                    Console.WriteLine(str1 + " and " + str2 + " are not anagrams !!");
                                }
                            }
                            break;

                    default: Console.WriteLine("Oops !! Invalid Choice...");
                             break;
                }
            }
    }
}
