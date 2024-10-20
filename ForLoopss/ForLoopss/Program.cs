using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopss
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5;
            //for (int i = a; i >= 1; i--)
            //{
            //    for (int j =a; j>=i; j--)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i-1; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}


            //for (int i = 2; i <= a; i++)
            //{
            //    for (int j =  a; j >= i; j--)
            //    {
            //        Console.Write("  ");
            //    }
            //    for (int j = 1; j <= i-1; j++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    for (int j = i; j >= 1; j--)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();



            string  s = "abcde";
            int size = s.Length-1;

            for (int i = size; i >= 0; i--)
            {
                for (int j =  size; j >= i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i-1; j++)
                {
                    Console.Write(s[j] + " ");
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(s[j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 1; i <= size; i++)
            {
                for (int j = size; j >= i; j--)
                {
                    Console.Write("  ");
                }
                for (int j = 0; j <= i-1; j++)
                {
                    Console.Write(s[j] + " ");
                }
                for (int j = i; j >= 0; j--)
                {
                    Console.Write(s[j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
