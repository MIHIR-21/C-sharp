using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = Console.ReadLine();
            //string number = Console.ReadLine();

            //Console.WriteLine($"Your name is {name}. and your number is {number}");

            // int age = 1;
            // if(age > 18)  
            // {
            //     Console.WriteLine("you can drive");
            // }
            // else
            // {
            //     Console.WriteLine("you cannot drive");
            // }

            // int i = 0;
            // {
            // while (i < 5)
            //     Console.WriteLine(i);
            //     i++;
            // }

            int a = 5;
            for (int i = 1; i<=a; i++)
            {
                for (int j =i; j<=a; j++)
                {
                    Console.Write(j + " ");
                }
                 Console.Write("\n");
            } 

            Console.ReadLine();
        }
    }
}   
            