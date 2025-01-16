using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*/Date: Oct 1/2024
//Author: Simon Cui
//Course: CMPE1300
//Class: A03

 *This programs is meant the simulate the Rock paper scissors game where two people make a play of either rock, paper, and scissors. 
 *Rock beats scissors, paper beats rock, and scissors beats paper. If both players make the same output then the result of the
 *
 * Case computerGeneratedNumber
 * INPUT Yourplay --> your input into the rock paper scissors game
 * 
 * CALCULATE Random generated number
 * computerGeneratedNumber = Random integerfrom 0-2
 * case computerGeneratedNumber of
 * 0: computerChoice = "rock"
 * 1: computerChoice = "paper"
 * 2: computerChoice = "scissors"
 * Endcase
 *
 *
  *  
 *  case yourPlay of
 *     "Paper": case computerChoice of 
 *                      "rock": win
 *                      "paper": tie
 *                      "scissors": lose
 *  
 *  "Rock"      case computerChoice of 
 *                      "rock": tie
 *                      "paper": lose
 *                      "scissors": win
 *  
 *  "Scissors"  case computerChoice of 
 *                      "rock": lose
 *                      "paper": win
 *                      "scissors": tie
 * ELSE:System.Environment.Exit
 * OUTPUT: Fight Result (who won)
 * End of code
 */
namespace ICA4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string yourPlay;
            int computerGeneratedNumber;//stores the computer generated number
            string computerChoice = "";// stores what the computer choice depending on the number
            Console.CursorLeft = 60;
            //the beginnings of the program
            Console.WriteLine("ICA4 -Fall2024- Paper, Rock Scissors");
            Console.WriteLine("Select from the following choices:");
            Console.WriteLine("");
            Console.WriteLine("Paper");
            Console.WriteLine("Rock");
            Console.WriteLine("Scissors");
            Console.WriteLine();
            Console.WriteLine("Your selection:");
            Console.SetCursorPosition(15,7);

            yourPlay = Console.ReadLine();//The play that you made

            //Generates a random number from 0-2
            Random generatedNumber = new Random();
            computerGeneratedNumber = generatedNumber.Next(3);

            yourPlay =  yourPlay.ToLower();

            switch (computerGeneratedNumber)//Depending on the number from 0-2, rock, paper, scissors may be picked
            {
                case 0:
                    computerChoice = "rock";

                    break;
                case 1:
                    computerChoice = "paper";
                    break;
                case 2:
                    computerChoice = "scissors";
                    break;
            }
           
            switch (yourPlay)
            {
                case "scissors":
                    Console.WriteLine($"While you picked {yourPlay}, the computer chose {computerChoice}");
                    switch (computerChoice)//The outputs for every computer chosen value if your chose scissors
                    {
                        case "rock":
                            Console.WriteLine("Rock crushes your scissors, you lose!");
                            break;
                        case "paper":
                            Console.WriteLine("Your scissors cut paper, you win!");
                            break;
                        case "scissors":
                            Console.WriteLine("Same object picked, it's a tie!");
                            break;
                    }
                    break;
                case "rock":
                    Console.WriteLine($"While you picked {yourPlay}, the computer chose {computerChoice}");
                    switch (computerChoice)//The outputs for every computer chosen value if your chose rock
                    {
                        case "rock":
                            Console.WriteLine("Same object picked, it's a tie!");
                        break;
                        case "paper":
                            Console.WriteLine("Your rock got covered by paper, you lose!");
                            break;
                        case "scissors":
                            Console.WriteLine("Your rock smashes the scissors, you win?");
                            break;
                    }
                    break;
                case "paper":
                    Console.WriteLine($"While you picked {yourPlay}, the computer chose {computerChoice}");
                    switch (computerChoice)////The outputs for every computer chosen value if your chose paper
                    {
                        case "rock":
                            Console.WriteLine("Your paper covers the rock, you win!");
                            break;
                        case "paper":
                            Console.WriteLine("Same object picked, it's a tie!");
                            break;
                        case "scissors":
                            Console.WriteLine("Your paper gets cut by the scissors, you lose!");
                            break;
                    }
                    break;
                         default:
                    //when an invalid number is entered, program exits
                    Console.WriteLine("Please input a valid number");
                    Console.WriteLine("Press any key to exit");
                    Console.ReadKey();
                    System.Environment.Exit(0);
                    break;
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();//end of program


        }
    }
}
