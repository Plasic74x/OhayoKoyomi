using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*   while (guess is not valid) or (guess<1) or (guess>100)
 * SET rand = Random(1,100)
 * do
 * INPUT guess
 * do
 *      SET correctValue == false;
 *     If (guess is not valid)
 *     OUTPUT "guess not a valid value
 *     ELSE 
 *    
 *     IF((guess<0) ir (guess>100) Then 
 *     OUTPUT "guess out of range, please pick a number between 1 and 100"
 *     ENDIF
 *      
 *     ELSE
 *     correctValue = true
 *     ENDIF
 *     while (Not correctValue)
 *     count= count+1
 *     IF (guess<rand)
 *     OUTPUT "guess is smaller than the target number")
 *     ENDIF
 *     ELSE IF (guess> rand)
 *     OUPUT "Too High"
       ENDIF
       Count = Count+1

        While (rand!=guess)
        OUTPUT "Guess is right"
        OUTPUT guess
        OUTPUT Count
       

        OUTPUT "Play Again? Y/N"
        Input usersAnswer
While (userAnswer =="Y)
        


 * */
namespace Guess_the_number_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userAnswer;
            Random random = new Random();
            userAnswer = "yes";
            int rand = random.Next(1, 100);
            do
            {
                int count = 0;
               
                int guess;
                Console.WriteLine(rand);
                //guess = rand;
                do
                {
                    bool correctValue;
                    do
                    {
                        
                        correctValue = false;
                        Console.Write("Input your guess: ");
                        bool success = int.TryParse(Console.ReadLine(), out guess);
                        if (!success)
                        {
                            Console.WriteLine("Invalid guess value; it must be an integer");
                        }
                        else if (guess < 0 || guess > 100)
                        {
                            Console.WriteLine("Your guess is out of range, try again");
                        }
                        else
                        {
                            correctValue = true;
                        }
                    } while (!correctValue);
                    if (rand > guess)
                    {
                        Console.WriteLine("Your guess to too low oh my god");
                    }
                    if (rand < guess)
                    {
                        Console.WriteLine("Your guess is too high bruh");
                    }
                    if(guess == 69)
                    {
                        Console.WriteLine("I'm gonna touch you");
                    }
                    count++;
                } while (rand != guess);
                Console.WriteLine("Your guess is real i think");
                Console.WriteLine($"the secret number is {guess}");
                Console.Write("Would you like to play this again?");
                userAnswer = Console.ReadLine();
            } while (userAnswer == "yes");

        }
    }
}
