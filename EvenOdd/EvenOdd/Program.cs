using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a =3;
            //Console.WriteLine("Enter a number");
            //a = int.Parse(Console.ReadLine());

            //if (a % 2 == 0)
            //{
            //    Console.WriteLine("The Number is Even" + " " + a);
            //    Console.ReadLine();
            //}
            //else if (a % 2 != 0) 
            //{
            //    Console.WriteLine("The Number is Odd" + " " + a);
            //    Console.ReadLine();
            //}


            //IEnumerable<int> oddNums =
            //Enumerable.Range(1, 100).Where(x => x % 2 != 0);
            //foreach (int n in oddNums)
            //{
            //    Console.WriteLine(n);
            //}

            int a, b;
            Console.WriteLine("Its Prints Odd Numbers in given range..");
            Console.WriteLine();
            Console.WriteLine("Enter Starting Number : ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ending Number : ");
            b = int.Parse(Console.ReadLine());

            for (int i = a; i <= b; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }

            }


           Console.ReadKey();
        }
    }
}
