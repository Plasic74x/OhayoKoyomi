using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switches____
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string prov;
           prov = Console.ReadLine();


            switch(prov)
            {
                case "AB": Console.WriteLine("Alberta");
                    break;
                case "BC":
                    Console.WriteLine("Columbia British");
                    break;
                case "ON":
                    Console.WriteLine("Ontario");
                    break;
                default:
                    Console.WriteLine("Don't worry, i'm the strongest");
                    break;
                    int val;
                    Console.WriteLine("Input a value for val");
                    int.TryParse(Console.ReadLine(), out val);
                    int abs = (val < 0) ? -val: val;
                    Console.WriteLine($"The absolute value of {val} is {abs}");
            }
        }
    }
}
