using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Program_1 :
            //ArrayList stu = new ArrayList();

            //stu.Add("Student_1");
            //stu.Add("Student_2");
            //stu.Add("Student_3");
            //stu.Add("Student_4");
            //stu.Add("Student_5");

            //foreach (object obj in stu)
            //{ 
            //    Console.WriteLine(obj.ToString());
            //}

            //Console.WriteLine("--------");

            //stu.Remove("Student_3");
            //stu.RemoveAt(1);
            //stu.RemoveRange(0, 2);

            //foreach (object obj in stu)
            //{
            //    Console.WriteLine(obj.ToString());
            //}

            //Console.WriteLine("--------");

            //stu.Clear();
            //foreach (object obj in stu)
            //{ 
            //    Console.WriteLine(obj.ToString());
            //}
            //Console.WriteLine("All Clear !!");

            //Console.WriteLine("--------");



            // Program_2 :
            //List<string> list = new List<string>();

            //list.Add("Stu 1");
            //list.Add("Stu 2");
            //list.Add("Stu 3");
            //list.Add("Stu 4");
            //list.Add("Stu 6");
            //list.Add("Stu 5");

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("-*-*-*-*-");

            //list.Remove("Stu 3");
            //list.RemoveAt(1);
            //list.RemoveRange(1,2);

            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine();
            //Console.WriteLine("-*-*-*-*-");

            //list.Clear();
            //foreach (string item in list)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("All Clear !!");

            //Console.WriteLine();
            //Console.WriteLine("-*-*-*-*-");




            // Program_3 :
            //Stack s1 = new Stack(); 

            //s1.Push("Krisha");
            //s1.Push("Busa");
            //s1.Push("Rajkot");
            //s1.Push("Gujarat");
            //s1.Push("India");

            //foreach(string str in s1)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine();
            //Console.WriteLine("- - - -");

            //s1.Pop();

            //foreach (string str in s1)
            //{
            //    Console.WriteLine(str);
            //}

            //Console.WriteLine();
            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Elemnt : {s1.Peek()} ");

            //Console.WriteLine();
            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Does stacvk contain Krisha ? : {s1.Contains("Krisha")}");

            //Console.WriteLine();
            //Console.WriteLine("- - - -");

            //s1.Clear();
            //foreach(string str in s1)
            //{
            //    Console.WriteLine(str);
            //}
            //Console.WriteLine("All Clear !!");

            //Console.WriteLine();
            //Console.WriteLine("- - - -");




            // Program_4 :
            //Queue queue = new Queue();

            //queue.Enqueue(101);
            //queue.Enqueue(102);
            //queue.Enqueue(103);
            //queue.Enqueue(104);
            //queue.Enqueue(105);

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("- - - -");

            //queue.Dequeue();

            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Element : {queue.Peek()}");

            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Does queue contain 111 ? : {queue.Contains(111)}");

            //Console.WriteLine("- - - -");

            //queue.Clear();
            //foreach (int i in queue)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("All Clear !!");

            //Console.WriteLine("- - - -");




            // Program_5 :
            //Dictionary<int,string> studentDictionary = new Dictionary<int,string>();

            //studentDictionary.Add(101, "Stu 1");
            //studentDictionary.Add(102, "Stu 2");
            //studentDictionary.Add(103, "Stu 3");
            //studentDictionary.Add(104, "Stu 4");
            //studentDictionary.Add(105, "Stu 5");

            //foreach(KeyValuePair<int,String> key in studentDictionary)
            //{
            //    Console.WriteLine($"Key : {key.Key} , Value : {key.Value}");
            //}

            //Console.WriteLine("- - - -");

            //studentDictionary.Remove(102);

            //foreach (KeyValuePair<int, String> key in studentDictionary)
            //{
            //    Console.WriteLine($"Key : {key.Key} , Value : {key.Value}");
            //}

            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Does dictionary contain key 110 ? : {studentDictionary.ContainsKey(110)}");

            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Does dictionary contain vaule Stu 4 ? : {studentDictionary.ContainsValue("Stu 4")}");

            //Console.WriteLine("- - - -");

            //studentDictionary.Clear();
            //foreach (KeyValuePair<int, String> key in studentDictionary)
            //{
            //    Console.WriteLine($"Key : {key.Key} , Value : {key.Value}");
            //}
            //Console.WriteLine("All Clear !!");

            //Console.WriteLine("- - - -");




            // Program_6 :
            //Hashtable ht = new Hashtable();

            //ht.Add("Krisha",1);
            //ht.Add("Busa",2);
            //ht.Add("Rajkot",3);

            //foreach (object key in ht.Keys) 
            //{
            //    Console.WriteLine(key + ":" + ht[key]);
            //}

            //Console.WriteLine("- - - -");

            //ht.Remove("Rajkot");

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + ":" + ht[key]);
            //}

            //Console.WriteLine("- - - -");

            //Console.WriteLine($"Does the hashtable contain key Busa ? : {ht.ContainsKey("Busa")}");
            //Console.WriteLine($"Does the hashtable contain value 5 ? : {ht.ContainsValue(5)}");

            //Console.WriteLine("- - - -");

            //ht.Clear();

            //foreach (object key in ht.Keys)
            //{
            //    Console.WriteLine(key + ":" + ht[key]);
            //}
            //Console.WriteLine("All clear !!");

            //Console.WriteLine("- - - -");
        }
    }
}
