using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
//Date: Sep. 15/2024
//Author: Simon Cui
//Course: CMPE1300
//Class: A03
/*
 * This programs allows you to input the radius of either of a circle and sphere and then prompts you to find either the area of a circle or the volume of a sphere
 * when 'area' or 'code' is typed respectively. This program closes if an invalid radius in inputed (anything 0 or less) and if any string variable other than 'area' or 'volume' is inputed next
 * INPUT radius
 * INPUT boolean check
 * if(!check) then
 * OUTPUT Exiting the program   
 * 
 * INPUT input ------> for asking area or volume
 * if(input == radius) then
 * CALCULATE totalArea (Math.Pow(radius, 2.0)*Math.PI)
 * 
 * else if(input == volume)
 * CALCULATE totalVolume (4.00 / 3.00 * Math.PI * Math.Pow(radius, 3))
 * 
 * else 
 *OUTPUT Exiting the program
 *
 * OUTPUT totalArea
 * OUTPUT totalVolum    e
 */
namespace ICA3__Fall2024__Calc_Area_Circ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.CursorLeft = 60;
            Console.WriteLine($"ICA2-Simon Cui");
            //input for either radius or volume
            string input;
            // variables for storing the radius, the totalarea, and volume
            double radius,totalArea, totalVolume;
            //Prompts radius to be typed in
            Console.WriteLine("What is the radius of the circle or sphere?");
            bool check = double.TryParse(Console.ReadLine(), out radius);
            //In the case of an invalid radius entered, the program will exit
            if (!check)
            {
                Console.WriteLine("Invalid radius value, exiting");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            if (radius <= 0)
            {
                Console.WriteLine("Enter a value greater than zero, exiting");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
            }

            // Second input to determine if area or volume is being calculated not case sensitive
            Console.WriteLine("What are you calculating ('area' or 'volume')?");
            input = Console.ReadLine();
            input = input.ToLower();
            //Calculates area
            if (input == "area")
            {
                totalArea = (Math.Pow(radius, 2.0)*Math.PI);
                Console.WriteLine($"Total area is {totalArea:F1}");
            }
            //Calculates volume
           else if (input == "volume")
            {
                totalVolume = (4.00 / 3.00 * Math.PI * Math.Pow(radius, 3));
                Console.WriteLine($"Total volume is {totalVolume:F1}");
            }
            //If neither is typed
            else
            {
                Console.WriteLine("Invalid, program will now exit");
            
            }
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
            
        }
    }
}
//str=str.ToLower();
