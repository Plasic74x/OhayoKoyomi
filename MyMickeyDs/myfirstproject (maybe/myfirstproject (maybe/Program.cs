using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstproject__maybe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 569;
            //Console.Write is a thing that doesn't add it's own lines 
            string str = "steps ahead of me";
            Console.WriteLine("eto.....");
            Console.WriteLine("The Black Dog Was Big " + x);
            Console.WriteLine("I saw the man on the hill with a telescope");

            Console.WriteLine($"Why are you walking so fast? You are {x} {str}.");
        }
    }
}
