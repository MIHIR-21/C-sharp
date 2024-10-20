using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int playerRandomNum;
            //int enemyRandomNum;

            //int playerPoints = 0;
            //int enemyPoints = 0;

            //Random random = new Random();

            //for (int i = 0; i < 10; i++)
            //{

            //    Console.WriteLine("Press any key for roll the dice.");

            //    Console.ReadKey();

            //    playerRandomNum = random.Next(1, 7);
            //    Console.WriteLine("Your rolled a " + playerRandomNum);

            //    Console.WriteLine("........");
            //    System.Threading.Thread.Sleep(1000);

            //    enemyRandomNum = random.Next(1, 7);
            //    Console.WriteLine("Enemy AI Rolled a " +  enemyRandomNum);

            //    if (playerRandomNum > enemyRandomNum)
            //    {
            //        playerPoints++;
            //        Console.WriteLine("Player wins this round!");
            //    }
            //    else if (playerRandomNum < enemyRandomNum)
            //    {
            //        enemyPoints++;
            //        Console.WriteLine("Enemy Wins this round!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Draw!");
            //    }

            //    Console.WriteLine("The score is now " + "Player :" + playerPoints + ". Enemy :"+ enemyPoints + ".");
            //    Console.WriteLine();
            //}

            //if (playerPoints > enemyPoints)
            //{
            //    Console.WriteLine("You Win!");
            //}
            //else if (playerPoints < enemyPoints)
            //{
            //    Console.WriteLine("You Lose!");

            //}
            //else
            //{
            //    Console.WriteLine("Its a Draw!");
            //}
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key for roll the dice.");

                Console.ReadKey();

                playerRandomNum = random.Next(1,7);
                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy Rollod a " +  enemyRandomNum);


            
                if(playerRandomNum > enemyRandomNum)
                {
                    playerPoints++;
                    Console.WriteLine("Player Wins this round!");
                }
                else if(playerRandomNum < enemyRandomNum)
                {
                    enemyPoints++;
                    Console.WriteLine("Enemy Wins this round!");
                }
                else
                {
                    Console.WriteLine("Its a Draw!");
                }

                Console.WriteLine("Score is : " + "Player : " + playerPoints + ". Enemy : " + enemyPoints + ".");
                Console.WriteLine();
            }

            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("You Win!");
            }
            else if (playerPoints < enemyPoints)
            {
                Console.WriteLine("You Lose!");
            }
            else
            {
                Console.WriteLine("Draw!");
            }

            Console.ReadKey();
        }
    }
}
