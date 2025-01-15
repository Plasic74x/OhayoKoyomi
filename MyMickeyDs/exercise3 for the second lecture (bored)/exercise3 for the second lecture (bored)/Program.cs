using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise3_for_the_second_lecture__bored_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double hour1,income;
            Console.WriteLine("How many hours have you worked");
            double.TryParse(Console.ReadLine(), out hour1);
            Console.WriteLine("How much do they make every hour");
            double.TryParse(Console.ReadLine(), out income);
            Console.WriteLine($"Youre a noob, you made only {hour1 * income}");
         
        }
    }
}
