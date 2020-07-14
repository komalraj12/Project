using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalci
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int a, b;
                string choice;
                int answer;
                Console.WriteLine("Enter the numbers ");
                a = Convert.ToInt32(Console.ReadLine());
                b = Convert.ToInt32(Console.ReadLine());
                Console.Write(" enter your operation ( x , / , +, -) ");
                choice = Console.ReadLine();

                if (choice == "x")
                {
                    answer = a * b;
                    Console.WriteLine(a + " x " + b + " = " + answer);
                    Console.ReadLine();
                }
                else if (choice == "/")
                {
                    answer = a / b;
                    Console.WriteLine(a + " / " + b + " = " + answer);
                    Console.ReadLine();
                }

                else if (choice == "+")
                {
                    answer = a + b;
                    Console.WriteLine(a + " + " + b + " = " + answer);
                    Console.ReadLine();
                }
                else if (choice == "-")
                {
                    answer = a - b;
                    Console.WriteLine(a + " - " + b + " = " + answer);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Invalid choice");
                    Console.ReadLine();
                }
            }
        }
    }
}
