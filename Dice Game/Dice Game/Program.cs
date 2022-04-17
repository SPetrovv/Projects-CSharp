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
            int player1RandomNum;
            int player2RandomNum;

            int player1Points = 0;
            int player2Points = 0;  

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press any key to roll the dice.");

                Console.ReadKey();

                player1RandomNum = random.Next(1,7);
                Console.WriteLine("You rolled a " + player1RandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);


                player2RandomNum = random.Next(1,7);
                Console.WriteLine("Second player rolled a " + player2RandomNum);
                System.Threading.Thread.Sleep(1000);    

                if(player1RandomNum > player2RandomNum)
                {
                    player1Points++;
                    Console.WriteLine("Player 1 wins this round!");
                }
                else if (player2RandomNum > player1RandomNum)
                {
                    player2Points++;    
                    Console.WriteLine("Player 2 wins this round!");
                }
                else
                {
                    Console.WriteLine("Draw!");
                }

                Console.WriteLine("The score:");
                Console.WriteLine(player1Points + " : " + player2Points);

            }

            if (player1Points > player2Points)
            {
                Console.WriteLine("You win!");
            }
            else if (player2Points > player1Points)
            {
                Console.WriteLine("You lose!");
            }
            else
            {
                Console.WriteLine("It's a draw");
            }

            Console.Read();

           
        }
    }
}
