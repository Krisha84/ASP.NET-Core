using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestD
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1 :
            //User[] users = new User[5];
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Enter details for user " + (i + 1));
            //    Console.Write("Name : ");
            //    string name = Console.ReadLine();
            //    Console.Write("Age : ");
            //    int age = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("Email : ");
            //    string email = Console.ReadLine();
            //    Console.Write("City : ");
            //    string city = Console.ReadLine();

            //    users[i] = new User(name, age, email, city);
            //}

            //User oldestUser = users[0];

            //foreach (var user in users)
            //{
            //    if (user.Age > oldestUser.Age)
            //    {
            //        oldestUser = user;
            //    }
            //}
            //Console.WriteLine("User with highest age : " + oldestUser.Name + " , Age : " + oldestUser.Age);




            // Program-2 :
            //Console.Write("Enter a number to check if it's an Armstrong number : ");
            //int n = Convert.ToInt32(Console.ReadLine());

            //int temp = n;
            //int sum = 0;
            //int digits = n.ToString().Length;

            //while (temp != 0)
            //{
            //    int digit = temp % 10;
            //    sum += (int)Math.Pow(digit, digits);
            //    temp /= 10;
            //}
            //if (sum == n)
            //{
            //    Console.WriteLine(n + " is an Armstrong number !!");
            //}
            //else
            //{
            //    Console.WriteLine(n + " is not an Armstrong number !!");
            //}




            // Program-3 :
            //try
            //{
            //    Console.WriteLine("Enter marks for three subjects:");
            //    int[] marks = new int[3];
            //    int total = 0;

            //    for (int i = 0; i < 3; i++)
            //    {
            //        Console.Write("Subject " + (i + 1) + " marks : ");
            //        marks[i] = Convert.ToInt32(Console.ReadLine());

            //        if (marks[i] < 0 || marks[i] > 100)
            //            throw new InvalidMarksException();
            //        total += marks[i];
            //    }

            //    double percentage = (double)total / 3;
            //    Console.WriteLine("Total Marks : " + total + " , Percentage : " + percentage + "%");
            //}
            //catch (InvalidMarksException e)
            //{
            //    Console.WriteLine(e.Message);
            //}




            // Program-4 :
            //Console.Write("Enter a paragraph : ");
            //string paragraph = Console.ReadLine();

            //string[] words = paragraph.Split(' ');
            //string longestWord = "";

            //foreach (var word in words)
            //{
            //    if (word.Length > longestWord.Length)
            //        longestWord = word;
            //}

            //Console.WriteLine("Longest word : " + longestWord);

            //Console.Write("Enter a word to replace : ");
            //string wordToReplace = Console.ReadLine();

            //Console.Write("Enter the new word : ");
            //string replacementWord = Console.ReadLine();

            //string updatedParagraph = paragraph.Replace(wordToReplace, replacementWord);
            //Console.WriteLine("Updated paragraph: " + updatedParagraph);




            // Program-5 :
            //Shape shape = new Shape();
            //Console.WriteLine("Area of Circle : " + shape.Area(5));
            //Console.WriteLine("Area of Rectangle : " + shape.Area(5, 10));
            //Console.WriteLine("Area of Triangle : " + shape.Area(5f, 10f));




            // Program-6 :
            //Time time1 = new Time(2, 50, 30);
            //Time time2 = new Time(1, 20, 45);
            //Time time3 = new Time(time1);

            //time3.AddTime(time2);
            //time3.DisplayTime();




            // Program-7 :
            //Stack<string> stack = new Stack<string>();

            //Console.Write("Enter a sentence : ");
            //string sentence = Console.ReadLine();

            //string[] wordsInSentence = sentence.Split(' ');

            //foreach (var word in wordsInSentence)
            //{
            //    stack.Push(word);
            //}

            //Console.WriteLine("Reversed Sentence :");
            //while (stack.Count > 0)
            //{
            //    Console.Write(stack.Pop() + " ");
            //}
        }
    }
}
