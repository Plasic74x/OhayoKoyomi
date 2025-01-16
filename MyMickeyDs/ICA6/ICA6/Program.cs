


/*
   *Date: Oct 1 / 2024
   *Author: Simon Cui
   *Course: CMPE1300
   *Class: A03
   *----------------------------------
   *This program allows you to display squares with a number of you choosing along with the side length, 
   *they will be generated in random locations but will never clip outside of the screen 
   *----------------------------------
   *do
   *
   *   
   *   While (numberCheck == 1)
   *   INPUT sidelength
   *       if(sideline is not valid)
   *       repeats the while loop
   *       endif
   *       else if(sideline is out of range)
   *       repeats the while loop
   *       end else if
   *       else
   *       numberCheck == 0
   *       end else
   *   end While
   *   
   *    While (Squares Check == 1)
   *   INPUT numSquares
   *       if(numSquares is not valid)
   *       repeats the while loop
   *       endif
   *       else if(numSquares is out of range)
   *       repeats the while loop
   *       end else if
   *       else
   *       Squares Cgeck == 0
   *       end else
   *   end While
  
   *   set Rand = Random()
   *   while (squareCount< numSquares)
   *     set randX = Rand(0,800)
   *     set randY = Rand(0,600)
   *      if (randX > 800 - sideLength )
                    
                        randX = 800 - sideLength;
          endif          
          if (randX < 0 + sideLength)
                    
                        randX = 0 + sideLength;
                    endif
                    if (randY > 600 - sideLength )
                    
                        randY = 600 - sideLength 
                    endif
                    if (randY < 0 + sideLength )
                    
                        randY = 0 + sideLength 
                    endif
OUTPUT Rectangle randX, randY, sideLength, sideLength, RandomColor;
   *   While (runningProgram == "y")
* */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GDIDrawer;
using System.Drawing;
namespace ICA6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sideLength, numberCheck,squareCount,numSquares,squaresCheck;
            string runningProgram = "y";
        
            Console.CursorLeft = 60;
            Console.WriteLine("ICA6- Simon Cui");
            do//This allows the user to keep running the program again
            {
                numberCheck = 1;
                squaresCheck = 1;
                sideLength = 0;
                numSquares = 0;
                squareCount = 0;
                while (numberCheck == 1)//Checks if number is a valid integer or is in range
                {
                    //Inputs
                    Console.WriteLine("Enter the side length of the squares");
                    bool valid = int.TryParse(Console.ReadLine(), out sideLength);

                    if (!valid)
                    {
                        Console.WriteLine("Invalid value, please enter an integer");//Checks for integer
                    }
                    else if (sideLength < 10 || sideLength > 200) //If sidelength is out of range
                    {
                        Console.WriteLine("Please enter an integer value between 10 and 210");
                    }
                    else
                    {
                        numberCheck = 0;
                    }
                }
                while (squaresCheck == 1)//Checks if the integer representing the number of squares is valid or in range
                {
                    Console.WriteLine("Enter the number of squares you want to display");

                    bool valid1 = int.TryParse(Console.ReadLine(), out numSquares);

                    if (!valid1)
                    {
                        Console.WriteLine("Invalid value, please enter an integer");
                    }
                    else if (numSquares < 0)
                    {
                        Console.WriteLine("Please enter an integer value between 10 and 210");
                    }
                    else
                    {
                        squaresCheck = 0;
                    }
                }
                Random random = new Random();
                //Random random1 = new Random();
                CDrawer canvas = new CDrawer(800, 600);
               
                while (squareCount < numSquares)
                {



                    int randX = random.Next(0, 800);
                    int randY = random.Next(0, 600);
                    if (randX > 800 - sideLength )
                    {
                        randX = 800 - sideLength;
                    }
                    if (randX < 0 + sideLength/4)
                    {
                        randX = 0 + sideLength/4;
                    }
                    if (randY > 600 - sideLength )
                    {
                        randY = 600 - sideLength ;
                    }
                    if (randY < 0 + sideLength/4 )
                    {
                        randY = 0 + sideLength/4 ;
                    }
                    canvas.AddRectangle(randX, randY, sideLength, sideLength, RandColor.GetColor());
                    squareCount++;

                }
                Console.WriteLine("run program again? (y/n):");
                runningProgram = Console.ReadLine();
            } while (runningProgram == "y") ;
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
       
        }
    } 
}
