using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNumber;
            

            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("A number Between 1 to 10 will be Generated.");
            Console.WriteLine("If you guess the correct number,You Win!");

            Random random = new Random();

            randomNumber = random.Next(1,11);

            for (int i = 0; i < 10; i++)
            {

                Console.WriteLine("Pleas enter your guess.");
                double guess = Convert.ToDouble(Console.ReadLine());

                System.Threading.Thread.Sleep(1000);

                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high!");
                }
                else if (guess < randomNumber)
                {
                    Console.WriteLine("Your guess is too low!");
                }
                else
                {
                    Console.WriteLine("Correct!!");
                    Console.WriteLine("Congratulations.., You Win!");
                    Console.ReadLine();
                    break;
                }
            }
            
        }
    }
}
