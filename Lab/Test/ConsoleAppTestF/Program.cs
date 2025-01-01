using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTestF
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Program-1 :
            //int[] arr = { 10, 5, 8, 22, 3, 19 };
            //int max = arr[0];
            //int min = arr[0];

            //foreach (int num in arr)
            //{
            //    if (num > max)
            //    {
            //        max = num;
            //    }
            //    if (num < min)
            //    {
            //        min = num;
            //    }
            //}
            //Console.WriteLine("Maximum number: " + max);
            //Console.WriteLine("Minimum number: " + min);




            // Program-2 :
            //int totalSeconds = 3661;
            //int hours = totalSeconds / 3600;
            //int minutes = (totalSeconds % 3600) / 60;
            //int seconds = totalSeconds % 60;

            //Console.WriteLine(totalSeconds + " seconds = " + hours + "hour(s):" + minutes + "minute(s):" + seconds + "second(s)");




            // Program-3 :
            //Book book = new Book(101, "ABC", "XYZ");
            //book.DisplayBookDetails();



            // Program-4 :
            //Employee employee = new Employee();
            //employee.InputDetails();
            //employee.DisplayDetails();
            //employee.DeterminePerformance();




            // Program-5 :
            //ShoppingCart cart = new ShoppingCart();
            //cart.AddItem("Laptop", 1, 800.50);
            //cart.AddItem("Phone", 2);
            //cart.AddItem(101, 5);
            //cart.DisplayCart();




            // PRogram-6 :
            //Shape circle = new Circle(5);
            //Console.WriteLine(circle.Name + " Area : " + circle.CalculateArea());

            //Shape rectangle = new Rectangle(5, 3);
            //Console.WriteLine(rectangle.Name + " Area : " +rectangle.CalculateArea());




            // Program-7 :
            //int[] arr = { 1, 2, 1, 1, 2, 2, 2 };

            //Hashtable freqTable = new Hashtable();

            //foreach (int num in arr)
            //{
            //    if (freqTable.ContainsKey(num))
            //    {
            //        freqTable[num] = (int)freqTable[num] + 1;
            //    }
            //    else
            //    {
            //        freqTable.Add(num, 1);
            //    }
            //}

            //foreach (DictionaryEntry entry in freqTable)
            //{
            //    Console.WriteLine("Number " + entry.Key + " appears " + entry.Value + " times !!");
            //}
        }
    }
}
