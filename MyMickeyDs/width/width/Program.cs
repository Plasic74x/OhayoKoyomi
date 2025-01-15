using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace width
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The width of the console is {Console.WindowWidth}");
            Console.CursorLeft = 60;
            Console.WriteLine("YOU CANT CATCH ME IF YOU TRIED LOSER");
        }
    }
}
// YOU MORON REMEMBER THAT NEW PROJECTS ARE MADE WITH "console app (.net framework)"
//THIS IS FOR WITH DEBUGGING
//Console.WriteLine("Press any key to exit");
//Console.ReadKey();