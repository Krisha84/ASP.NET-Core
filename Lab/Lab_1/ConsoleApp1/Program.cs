using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the program number between 1 to 10 : ");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (n) 
            {
                case 1: // Program_1 :
                        Console.WriteLine("Krisha_Busa");
                        Console.WriteLine("Address : Shraddhadeep Park");
                        Console.WriteLine("0123456789");
                        Console.WriteLine("Rajkot");
                        break;


                case 2: // Program_2 : 
                        Console.WriteLine("Enter the number a : ");
                        int a = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the number b : ");
                        int b = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("a : " + a);
                        Console.WriteLine("b : " + b);
                        break;


                case 3: // Program_3 : 
                        Console.WriteLine("Enter your name : ");
                        String name = Console.ReadLine();

                        Console.WriteLine("Enter your country name : ");
                        String country = Console.ReadLine();

                        Console.WriteLine("Hello !! " + name + " from country " + country);
                        break;


                case 4: // Program_4 : 
                        Console.WriteLine("Enter the length : ");
                        int l = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter the width : ");
                        int w = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Area of ractangle : " + l * w + " square-feet");
                        break;


                case 5: // Program_5 :

                        // Square
                        Console.WriteLine("Enter the length of square: ");
                        int length = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Area of square : " + length * length);

                        // Rectangle
                        Console.WriteLine("Enter the length of rectangle : ");
                        int lr = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the width of rectangle : ");
                        int width = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Area of rectangle : " + lr * width);

                        // Circle
                        Console.WriteLine("Enter the radius of a circle : ");
                        float r = float.Parse(Console.ReadLine());

                        Console.WriteLine("Area of circle : " + Math.PI * r * r);
                        break;


                case 6: // Program_6 :

                        Console.WriteLine("Enter Celsius : ");
                        double celsius = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Fahrenheit : " + (celsius * (9 / 5)) + 32);

                        Console.WriteLine("Enter Fahrenheit : ");
                        double fahrenheit = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Celsius : " + (fahrenheit - 32) * (5 / 9));
                        break;


                case 7: // Progra_7 :

                        Console.WriteLine("Enter p : ");
                        int principal = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter r : ");
                        int rate = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter n : ");
                        int time = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Simple Interest : " + (principal * rate * time) / 100);
                        break;


                case 8: // Program_8 :

                        // Switch case
                        Console.WriteLine("Enter the number a : ");
                        double x = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Enter the number b : ");
                        double y = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Enter 1:Addition , 2:Multiplication , 3:Subtraction , 4:Division");
                        int choice = Convert.ToInt32(Console.ReadLine());

                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Addition : " + (x + y));
                                break;

                            case 2:
                                Console.WriteLine("Multiplication : " + (x * y));
                                break;

                            case 3:
                                Console.WriteLine("Subtraction : " + (x - y));
                                break;

                            case 4:
                                Console.WriteLine("Division : " + (x / y));
                                break;

                            default:
                                Console.WriteLine("Invalid Choice ...!!");
                                break;
                        }

                        // If else

                        //if (c == 1)
                        //{
                        //    Console.WriteLine("Addition : " + (a + b));
                        //}
                        //else if (c == 2)
                        //{
                        //    Console.WriteLine("Multiplication : " + (a * b));
                        //}
                        //else if (c == 3)
                        //{
                        //    Console.WriteLine("Subtraction : " + (a - b));
                        //}
                        //else if (c == 4)
                        //{
                        //    Console.WriteLine("Division : " + (a / b));
                        //}
                        //else
                        //{
                        //    Console.WriteLine("Invalid Choice ...!!");
                        break;


                case 9: // Program_9 :

                        Console.WriteLine("Enter the number a : ");
                        int n1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number b : ");
                        int n2 = Convert.ToInt32(Console.ReadLine());

                        n1 = n1 + n2;
                        n2 = n1 - n2;
                        n1 = n1 - n2;

                        Console.WriteLine("n1 : " + n1);
                        Console.WriteLine("n2 : " + n2);
                        break;


                case 10:  // Program_10 :
            
                        Console.WriteLine("Enter the number 1 : ");
                        int e = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number 2 : ");
                        int f = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the number 3 : ");
                        int g = Convert.ToInt32(Console.ReadLine());

                        int max = (e > f ? (e > g ? e : g) : (f > g ? f : g));
                        Console.WriteLine("Max : " + max);
                        break;


                default:
                        Console.WriteLine("Oops !! Invail Choice...");
                        break;

            }
        }
    }
}
