using System;
using System.Drawing;
using GDIDrawer;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*/Date: Oct 1/2024
//Author: Simon Cui
//Course: CMPE1300
//Class: A03

/*This program allows you do display the size of a cricle along with its coordinates by using GDIDrawer while only taking in integer values
 * 
 * INPUT Diameter
 * INPUT positionX
 * INPUT positionY
 * 
 * if(checkDiameter = false)
 *      exits program
 * endifd
 * 
 * if(diameter<10 )
 * diameter = 10
 * endif
 * 
 * if(diameter>100)
 * diameter = 100
 * endif
 * 
 *  if(checkX = false)
 *  OUTPUT = "not valid"
 *      exits programwe
 * endif
 *  if(checkY = false)
 *  OUTPUT = "not valid"
 *      exits program
 * endif
 * if(positionX<0)
 * positionX = 0+diameter
 * endif
 * if(positionX>300)
 * positionX = 399-diameter
 * endif
 * if(positionY<0)
 * positionX = 0+diameter
 * endif
 * if(positionY>300)
 * positionX = 399-diameter
 * endif
 *  CDrawer Canvas = new CDrawer(300, 300);
 * OUTPUT = Add Center Ellipse(positionX,positionY, diameter, diameter)
 * end of code
 */
namespace ICA5
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int diameter, centerX, centerY;
            Console.WriteLine("What do you want the diameter to be");
            //int.TryParse(Console.ReadLine(), out diameter);
            bool checkDiameter = int.TryParse(Console.ReadLine(), out diameter);
            //In the case of an invalid radius entered, the program will exit
            if (!checkDiameter)
            {
                Console.WriteLine("Invalid diameter value, exiting");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            if (diameter < 10)//if a diameter out of range is entered is outside of the range the program exits
            {
                diameter = 10;
               
            }
            if (diameter > 100)//if a diameter out of range is entered is outside of the range the program exits
            {
                diameter = 100;

            }
            Console.WriteLine("What do you want the x position to be");//inputting the x coordinate
         bool checkX=   int.TryParse(Console.ReadLine(), out centerX);
            if (!checkX)//verifying that the input is an integer exits if otherwise
            {
                Console.WriteLine("Invalid X value (please enter a valid integer),  exiting");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            if (centerX < 0+diameter)//moves the circle's position to the left edge if x is negative
            {
                centerX = 0+diameter/2;
            }
            else if (centerX > 300-diameter)//moves the circle's position to the left edge if coordinate x is more than 300
            {
                centerX = 300-diameter/2;
            }
            Console.WriteLine("What do you want the y position to be");//inputting the y coordinate
        bool checkY=    int.TryParse(Console.ReadLine(), out centerY);
            if (!checkY)//verifying that the input is an integer exits if otherwise
            {
                Console.WriteLine("Invalid Y value (please enter a valid integer),  exiting");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
                System.Environment.Exit(0);
            }
            if (centerY < 0+diameter)
            {

                centerY = 0 + diameter/2; //moves the circle's position to the top edge if Y is negative
            }
            else if (centerY > 300 - diameter)
            {
                centerY = 300 - diameter/2;//moves the circle's position to the bottom edge if Y is more than 300
            }
            CDrawer Canvas = new CDrawer(300, 300);
            Canvas.AddCenteredEllipse(centerX,centerY,diameter,diameter,Color.Red);
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
