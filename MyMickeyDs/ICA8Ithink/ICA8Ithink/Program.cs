using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*

This program displays a shape using asterisks which are lines, squares, and triangles which the user can input the size of the shape from 5-25 
and the program will change the shape appearence to match it correctly
-----------------------------------------------------------------------
 int shapeSize;//The input for the shape sizes
            int spaceCount = 0;
            int sizeCheck = 0;
            int lineCount = 0;
            int starCount = 0;
            int shapeCheck = 0;
            string shape = "";
            string shapeLine = "*";
            string programRunning = "y"
do
    do
    INPUT ShapeSize
        if(ShapeSize is not valid)
    OUTPUT    "you have entered an invalid shape size value"
        
        else if (Shape size>25 || Shape size <5)
        OUTPUT "value is out of range"
        end else 
        else
        sizeCheck = 1
        endelse
        
        endif
    while sizeCheck = 0
    do
    INPUT Shape Name
          if(Shape name is not valid)
            OUTPUT "you have entered an invalid shape"
         
         else if(Shape name = "square")
         starCount = 0;
                       for (starCount = 0; starCount < shapeSize - 1; starCount++)
                        

                            shapeLine += "*";
                        end for
                        for (lineCount = 0; lineCount < shapeSize; lineCount++)
                        
                            Console.WriteLine(shapeLine);
                        end for 
                        shapeCheck = 1;
          OUTPUT square
          shapecheck = 1
          end else if
                 else if(Shape name = "line")
                        spaceCount= 0;
                        lineCount = 0;
                        for (lineCount = 0; lineCount < shapeSize; lineCount++)
                        
                            for (int i = 0; i < spaceCount; i++)
                            
                                Write " "

                            end for
                            Console.WriteLine(shapeLine);
                        end for

                            spaceCount += 1;
                            
          shapecheck = 1
          starCount = 0;
                        for (starCount = 0; starCount < shapeSize - 1; starCount++)
                        

                            shapeLine += "*";
                        end for
                        for (lineCount = 0; lineCount < shapeSize; lineCount++)
                        
                            Console.WriteLine(shapeLine);
                        end for
                        shapeCheck = 1;
                    }
                end else 
                    else (Shape name = "triangle")
                        OUTPUT triangle
                         shapecheck = 1
                    end if
     while(shapecheck = 0)
    INPUT program running
while(program running = "y")


*/
namespace ICA8Ithink
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int shapeSize;//The input for the shape sizes
            int spaceCount = 0;//Counts how many spaces are needed for each row of the line shape
            int sizeCheck = 0;//Checks if the sie inputted is valid or not
            int lineCount = 0;//the number of rows for every shape that needed to be drawn
            int starCount = 0;//Counts the number of stars needed for every row on the square shape
            int shapeCheck = 0;
            string shape = "";//Stores the shape name
            string shapeLine = "*";//stores the shape appearance
            string programRunning = "y";//part of a for loop that keeps the program running
            Console.CursorLeft = 50;
            Console.WriteLine("ICA08 Simon Cui");
            do
            {
                do//checks if the shape size entered if valid
                {
                    Console.Write("Enter the shape size: ");//inputs the shape size
                    bool check = int.TryParse(Console.ReadLine(), out shapeSize);
                    if (!check)//if not an integer at all
                    {
                        Console.WriteLine("Please enter a valid integer");
                    }
                    else if (shapeSize < 5)
                    {
                        Console.WriteLine("Please enter a value greater than 4");
                    }
                    else if (shapeSize > 25)
                    {
                        Console.WriteLine("Please enter a value less than 26");
                    }
                    else
                    {
                        sizeCheck = 1;

                    }
                } while (sizeCheck == 0);
                do
                {
                    Console.Write("Input the shape that you want: ");
                    shape = Console.ReadLine();
                    shape = shape.ToLower();
                    if (shape != "line" && shape != "square" && shape != "triangle")
                    {
                        Console.WriteLine("You have entered an invalid shape, please enter either a line, square, and triangle");
                    }
                    else if (shape == "line")
                    {
                        spaceCount= 0;
                        lineCount = 0;
                        for (lineCount = 0; lineCount < shapeSize; lineCount++)
                        {
                            for (int i = 0; i < spaceCount; i++)
                            {
                                Console.Write(" ");

                            }
                            Console.WriteLine(shapeLine);

                            spaceCount += 1;
                            
                        }
                        shapeCheck = 1;
                    }
                    else if (shape == "triangle")
                    {
                        starCount = 0;
                        lineCount = 0;
                        for (lineCount = 0; lineCount < shapeSize; lineCount++)
                        {
                            for (int i = 0; i<starCount; i++)
                            {

                                Console.Write("*");

                            }
                            Console.WriteLine(shapeLine);
                            //shapeLine += "*";
                            starCount++;

                        }
                        shapeCheck = 1;
                    }
                    else if (shape == "square")
                    {
                        starCount = 0;
                        for (starCount = 0; starCount < shapeSize - 1; starCount++)
                        {

                            shapeLine += "*";

                        }
                        for (lineCount = 0; lineCount < shapeSize; lineCount++)
                        {
                            Console.WriteLine(shapeLine);
                           
                        }
                        shapeCheck = 1;
                    }
                } while (shapeCheck == 0);//checks if a valid shape is entered
                Console.WriteLine("Would you like to run the program again? (y/n)");//prompts user to run program again
                programRunning = Console.ReadLine();
            } while (programRunning == "y");
        }
    }
}
