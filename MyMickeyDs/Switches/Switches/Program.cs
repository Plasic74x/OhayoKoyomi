using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * INPUT radius
 * INPUT 
 */
namespace Switches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char answer;
            Console.WriteLine("Input a value for Answer");
            char.TryParse(Console.ReadLine(), out answer);
            switch (answer)
            {
                case 'x': Console.WriteLine("Exit");
                    break;
                case 'c':
                    Console.WriteLine("Continue");
                    break;
                case 's':
                    Console.WriteLine("Continue");
                    break;
                //We reach default when the value of our variable does not match any of the above cases
                default: Console.WriteLine("Wrong");
                    break;
            }
            Console.WriteLine("IM OUT OF THE SWITCH");
            Console.WriteLine("THE DEADLIEST TF2 PLAYER");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
