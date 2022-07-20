using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperSiccors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock Paper Sciccors");
            while (true)
            {
                Console.WriteLine("Are you ready? \nLet's Play!");

                string selectedChoice = SelectChoice();
                char yourChoice = char.Parse(selectedChoice);
                
                Console.WriteLine("You selected {0}", yourChoice);

                char opponetChoice = GetOpponentChoice();
                Console.WriteLine("I chose {0}", opponetChoice);

                DecideWinner(opponetChoice,yourChoice);

                Console.WriteLine("Do you want to play again?");
                Console.WriteLine("Enter YES to play again or any other key to finish...");

                string playAgain = Console.ReadLine();
                if (playAgain?.ToLower() == "yes") { 
                    continue;
                }
                else
                {
                    break;
                }
                    

                Console.ReadLine();
            }

        }
        /// <summary>
        /// This method validates the letter entered by the Player
        /// </summary>
        /// <returns>Returns a string with the letter</returns>
        public static string SelectChoice()
        {
            Console.WriteLine("Select a letter: [R]ock, [P]aper, [S]ciccors:");
            string selectedChoice = Console.ReadLine();

            if (selectedChoice?.ToLower() != "r" && selectedChoice?.ToLower() != "p" && selectedChoice?.ToLower() != "s")
            {
                Console.WriteLine("Please select only one letter R, P,or S:");
                selectedChoice = SelectChoice();

            }
            return selectedChoice;
        }

        public static char GetOpponentChoice()
        {
            char[] options = new char[] { 'R', 'P', 'S' };

            Random random = new Random();
            int randomIndex = random.Next(0, options.Length);

            return options[randomIndex];
        }

        public static void DecideWinner(char opponentChoice, char yourChoise)
        {
            if (opponentChoice == yourChoise)
            {
                Console.WriteLine("Tie!");
            }

            switch (yourChoise)
            {
                case 'R':
                case 'r':
                    if (opponentChoice == 'P')
                        Console.WriteLine("Papper beats rock, I win!");
                    else if (opponentChoice == 'S')
                        Console.WriteLine("Rock beats paper, You win!");
                    break;
                case 'S':
                case 's':
                    if (opponentChoice == 'P')
                        Console.WriteLine("Sissors beats paper, You win!");
                    else if (opponentChoice == 'R')
                        Console.WriteLine("Rock beats scissors, I win!");
                    break;
                case 'P':
                case 'p':
                    if (opponentChoice == 'S')
                        Console.WriteLine("Sissors beats paper, I win!");
                    else if (opponentChoice == 'R')
                        Console.WriteLine("Paper beats rock, You win!");
                    break;
                default:
                    break;
            }
        }
    }


        
    
}
