using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Whats_your_age__lennyface_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            string input;
            int person1;
            int person2;
           
            Console.WriteLine("how old are you  little one:");
//Alternate thing to do
            //   input = Console.ReadLine();
            //int.TryParse(input, out age);
            int.TryParse(Console.ReadLine(), out age); 

            Console.WriteLine($"The age of the jebus is: {age}");
            Console.WriteLine("How many poke balls does person one need?");
            int.TryParse(Console.ReadLine(), out person1);
            Console.WriteLine("How many pokemon balls does person two need");
            int.TryParse(Console.ReadLine(), out person2);
            Console.WriteLine($"Dawg, you need {person1 + person2} poke balls");
            Console.WriteLine("if u using debug press any key to exit (smile)");
            Console.ReadKey();
        }
    }
}
