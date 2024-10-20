using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double result = 0;
            string answer;

            Console.WriteLine("Enter the first number :");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number :");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What type of operation would you like to do ?");
            Console.WriteLine("Please enter a for addition, m for multiplication, s for subtraction and d for division");

            answer = Console.ReadLine();

            if (answer == "a")
            {
                result = num1 + num2;
            }
            else if (answer == "s")
            {
                result = num1 - num2;
            }
            else if (answer == "m")
            {
                result = num1 * num2;
            }
            else if (answer == "d")
            {
                if(num2 != 0)
                {
                    result = num1 / num2;
                }
                else
                {
                    Console.WriteLine("can not divided by zero");
                }
            }
            else
            {
                Console.WriteLine("Enter valid opration...");
                Console.ReadLine();
                return;
            }
            Console.WriteLine("Result :" + result);

            Console.ReadLine();
        }
    }
}
