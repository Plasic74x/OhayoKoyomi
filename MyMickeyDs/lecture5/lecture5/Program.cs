using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture5
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double root = Math.Sqrt(2.5);
            Console.WriteLine($"The square-root of 2.5 is {root:F3}");
            int y = 563217845;
            //(int) can be added for only integer values
               double root1 = (int)Math.Sqrt(y);
            Console.WriteLine($"Th esquareroot of {y} is: {root1}");
            double x = 53.457128;
                Console.WriteLine($"Math.Round{x,2} = {Math.Round(x,2)}");
            Console.WriteLine($"Math.Round{x} = {Math.Round(x)}");
            Console.WriteLine($"Math.Round{x},5, MidpointRoundingAwayFromZero) = {Math.Round(x, 5)}");
            Console.WriteLine($"Math.Ceiling {Math.Ceiling(x)}");
            Random burped = new Random();
            Console.WriteLine($"The generated number is {burped.NextDouble()*50}");

            double angle;
            angle = burped.NextDouble() * 90;
            double miskyworks = (Math.PI / 180) * angle;
            Console.WriteLine($"{miskyworks:F2} degrees= {miskyworks:F2} radians");
            Console.WriteLine($"Angle: {angle}, Cos: {Math.Cos(miskyworks)}, Sine: {Math.Sin(miskyworks)}");

        }
    }
}
