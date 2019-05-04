using System;
using System.Collections.Generic;


// Requirements:
// Visualization
// Users are prompted to choose "Rock, Paper or Scissors"
// Both players choices are displayed
// A winner is displayed
// Functionality
// Gracefully handles bad input without crashing
// Computer choice is random
// Stretch Goals (Requirements first! Then stretch goals.)
// Utilize a while loop to allow the user to play multiple instances of the game during one execution of the program.
// Keep a track of the user's and computer's games won and display this stats with the other results at the end of a game.
// Extend this game to include more options, namely Rock, Paper, Scissors, Lizard, Spock, etc.

namespace rpsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            int playerWins = 0;
            int computerWins = 0;
            int ties = 0;
            bool quit = false;

            while(! quit){
                Random num = new Random();
                System.Console.WriteLine("Please choose rock, paper, or scissors: ");
                string playerChoice = System.Console.ReadLine().ToLower();
                int computerChoice = num.Next(0,3);

                //TODO: make array of playerChoices, make "wins" array for each choice (ex: string[] rock = {scissors})
                //compare player choice to array to determine win/loss/tie. 

                if (computerChoice == 0) //0 = tie
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("It is a tie "); 
                        ties += 1;                    
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("It is a tie ");
                        ties += 1;

                    }
                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("It is a tie ");
                        ties += 1;
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");

                    }

                }

                else if (computerChoice == 1) //1 = computer wins
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("Sorry you lose, paper beat rock");
                        computerWins += 1;
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("Sorry you lose, scissors beat paper ");
                        computerWins += 1;
                    }
                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("Sorry you lose, rock beats scissors");  
                        computerWins += 1;                     
                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");        
                    }
                }
                else if (computerChoice == 2) //2 = player wins
                {
                    if (playerChoice == "rock")
                    {
                        Console.WriteLine("The computer chose scissors");
                        Console.WriteLine("You win, rock beats scissors");
                        playerWins += 1;
                    }
                    else if (playerChoice == "paper")
                    {
                        Console.WriteLine("The computer chose rock");
                        Console.WriteLine("You win, paper beats rock");
                        playerWins +=1;

                    }
                    else if (playerChoice == "scissors")
                    {
                        Console.WriteLine("The computer chose paper");
                        Console.WriteLine("You win, scissors beat paper");
                        playerWins += 1;

                    }
                    else
                    {
                        Console.WriteLine("You must choose rock, paper, or scissors!");

                    }

                }
                if ((playerWins - computerWins) > 5){
                    System.Console.WriteLine("Are you sure you're not cheating?");
                }
                //added option to reset the score in addition to keeping track of the win/loss/tie records.
                System.Console.WriteLine("The score is: You: {0} wins, Computer: {1} wins, and {2} ties.", playerWins, computerWins, ties);
                System.Console.WriteLine("Would you like to play again? (Press enter to continue, r to reset the score, or q to quit)");
                string playAgain = Console.ReadLine().ToLower();
                if(playAgain == "q"){
                    quit = true;
                } else if (playAgain == "r"){
                    Console.Clear();
                    playerWins = 0;
                    computerWins = 0;
                    ties = 0;
                }
            }
            System.Console.WriteLine("Thank you for playing! Goodbye.");
        }
    }
}
