using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Input numGrades
 * While (numGrades not valid or numgrades<2 or numGrades>10)
 * IF (NumGrades not Valid)
 * Display "invalid numerical value = Input again"
 * ELSE IF (numGrades<2 or numGrades>10)
 * Display "Out Of Range - Input Again"
 * ENDIF 
 * total = 0
INPUT numGrades
ENDWHILE
WHILE (counter<=numGrades)
Display "Input grade for grade number", counter
Input grade
counter = counter+1
ENDWHILE
 * */
namespace While_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numGrades;
            Console.WriteLine("How many grades do you want to input?");
            bool success = int.TryParse(Console.ReadLine(), out numGrades);
            while (!success || (numGrades < 2 || numGrades > 10))
            {
                ;
                if (!success)
                {
                    Console.WriteLine("You've entered aninput value, input an integer");

                }
                else
                {
                    Console.WriteLine("Your value is in the wrong range");
                    Console.WriteLine("Please Input the number of Grades again");
                    success = int.TryParse(Console.ReadLine(), out numGrades);
                }
            }
            int counter = 1;
            int total = 0;
            while (counter <= numGrades)
            {
                Console.WriteLine($"Input Value for both grade {counter}");
                int grade;
                int.TryParse(Console.ReadLine(), out grade);
                total += grade;
                   counter++;
            }
            double average = total / numGrades;
                Console.WriteLine($"Th e average of the grades is: {average}");
           
        }
    }
}
