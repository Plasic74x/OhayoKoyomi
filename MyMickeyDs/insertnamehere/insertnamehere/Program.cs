using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insertnamehere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name, character;
            Console.WriteLine($"What's a good anime that you watch?");
           
            name = Console.ReadLine();
            Console.WriteLine($"What is your favorite character in it?");
            character = Console.ReadLine();
            Console.WriteLine($"I love {name} but {character} is kinda mid");
           
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
           
        }
    }
}
// YOU MORON REMEMBER THAT NEW PROJECTS ARE MADE WITH "console app (.net framework)"
//THIS IS FOR WITH DEBUGGING
//Console.WriteLine("Press any key to exit");
//Console.ReadKey();