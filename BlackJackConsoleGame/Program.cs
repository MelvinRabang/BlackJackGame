using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackConsoleGame
{
    class Program
    {
        static int computerSum = 0;
        static int playerSum = 0;
        static string inputFromUser = "";
        static Boolean isPlayerWantsCardHit = false;
        static string YOU_LOSE_MSG = "Sorry. You Lose.";

        static void Main(string[] args)
        {
            playBlackjackGame();
        }

        static void playBlackjackGame()
        {
            
            Console.WriteLine("Your Cards: " + returnPlayerCard() + " "+ returnPlayerCard() + " = " + playerSum);
            Console.WriteLine("Computer Cards: " + returnComputerCard() + " " + returnComputerCard() + " = " + computerSum);

            hitThePlayerForCards();
            
                
        }

        static void hitThePlayerForCards()
        {
            do
            {
                Console.WriteLine("Do you want another card (y/n)?");
                inputFromUser = Console.ReadLine();
                if (inputFromUser.Equals("y"))
                {
                    Console.WriteLine("Hit: " + returnPlayerCard() + " Your total is " + playerSum);
                    int playerSumInt = Convert.ToInt32(playerSum);
                    if (playerSumInt > 21)
                    {
                        Console.WriteLine(YOU_LOSE_MSG);
                    } else
                    {
                        isPlayerWantsCardHit = true;
                    }
                }
                else if (inputFromUser.Equals("n"))
                {
                    hitTheComputerWithCards();
                    isPlayerWantsCardHit = false;
                }
                else
                {
                    isPlayerWantsCardHit = true;
                }
            } while (isPlayerWantsCardHit);
        }

        static String returnPlayerCard()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 10);

            playerSum += value;
            return value.ToString();
        }

        static String returnComputerCard()
        {
            Random rnd = new Random();
            int value = rnd.Next(1, 10);

            computerSum += value;
            return value.ToString();
        }

        static void hitTheComputerWithCards()
        {
            do
            {
                Console.WriteLine("The Computer takes a card: " + returnComputerCard());
            } while (computerSum < 17);

            evaluateIfPlayerIsWinnerOrLoser();
        }

        static void evaluateIfPlayerIsWinnerOrLoser()
        {
            Console.WriteLine("Your score: " + playerSum);
            Console.WriteLine("Your score: " + computerSum);
            Console.WriteLine();
            if (computerSum == playerSum)
            {
                Console.WriteLine("It is draw!");
            }
            else if (computerSum > playerSum)
            {
                Console.WriteLine(YOU_LOSE_MSG);
            }
            else if (computerSum < playerSum)
            {
                Console.WriteLine("You Won!");
            }
        }
    }
}
