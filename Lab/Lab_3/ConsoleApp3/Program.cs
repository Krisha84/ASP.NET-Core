using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Program_1 :
            //Console.WriteLine("Enter the number: ");
            //int a = Convert.ToInt32(Console.ReadLine());

            //int b = 0;

            //try
            //{
            //    int div = a / b;
            //}
            //catch (DivideByZeroException e){
            //    Console.WriteLine(e.Message);
            //}



            // Program_2 :
            //int[] arr = new Int32[5];

            //try
            //{
            //    Console.WriteLine("Enter elements into array : ");
            //    for (int i = 0; i < (arr.Length) + 1; i++)
            //    {
            //        arr[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}
            //catch (IndexOutOfRangeException e) { 
            //    Console.WriteLine(e.Message);
            //}


            // Program_3 :
            //Calculate c = new Calculate();

            //c.SumOfTwo(11, 111);
            //c.SumOfThree(10, 100, 1000);


            // Program_4 :
            //Result r = new Result();

            //r.Addition(11, 22);
            //r.Substraction(22,11);


            // Program_5 :

            //String s1 = "Darshan";
            //String s2 = "University";

            // Length
            //Console.WriteLine("Length of s1 : " + s1.Length);
            //Console.WriteLine("Length of s2 : " + s2.Length);

            // ToUpper-ToLower
            //Console.WriteLine("Upper case : " + s1.ToUpper() + " " + s2.ToUpper());
            //Console.WriteLine("Lower case : " + s1.ToLower() +  " " + s2.ToLower());

            // SubString
            //Console.WriteLine("Sub string : " + s1.Substring(0, 3));

            // Replace 
            //Console.WriteLine("New string : " + s2.Replace("Uni", "!!!"));

            // Concate 
            //Console.WriteLine("Concate : " + String.Concat(s1, "-", s2));

            // IndexOf
            //Console.WriteLine("Index of sh : " + s1.IndexOf("sh"));



            // Program_6 :
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();

            //string result = "";
            //foreach (char c in input)
            //{
            //    if (char.IsLower(c))
            //    {
            //        result += char.ToUpper(c);
            //    }
            //    else if (char.IsUpper(c))
            //    {
            //        result += char.ToLower(c);
            //    }
            //    else
            //    {
            //        result += c;
            //    }
            //}
            //Console.WriteLine("Modified string: " + result);



            // Program_7 :
            //Geometry g = new Geometry();

            //g.Circle(10);
            //g.Triangle(10, 2);
            //g.Square(11);


            // Program_8 :
            //try
            //{
            //    Console.WriteLine("Enter the number : ");
            //    int n = Convert.ToInt32(Console.ReadLine());

            //    if (n % 2 != 0)
            //    {
            //        throw new Exception("Number must be even !!");
            //    }
            //}

            //catch (Exception e) 
            //{ 
            //    Console.WriteLine(e.Message);
            //}



            // Program_9 :
            //Console.WriteLine("Enter a string : ");
            //string inputString = Console.ReadLine();

            //string longestWord = "";
            //int maxLength = 0;

            //string[] words = inputString.Split();

            //foreach (string word in words)
            //{
            //    if (word.Length > maxLength)
            //    {
            //        maxLength = word.Length;
            //        longestWord = word;
            //    }
            //}

            //Console.WriteLine("The longest word is: " + longestWord);


            // Program_10 :
            //Console.WriteLine("Enter a character : ");
            //char c = Console.ReadKey().KeyChar;
            //Console.WriteLine("");

            //if (char.IsUpper(c))
            //{
            //    char lowerChar = char.ToLower(c);
            //    Console.WriteLine("Lower case : "+ lowerChar);
            //}

            //else if (char.IsLower(c)) 
            //{ 
            //    char upperChar = char.ToUpper(c);
            //    Console.WriteLine("Upper case : "+ upperChar);
            //}

            //else
            //{
            //    Console.WriteLine("Oops...Invalid Input !!");
            //}
        }
    }
}
