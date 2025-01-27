using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * INPUT NUMBEROFDAYSWORKED
 * CACLCULATE BASIC INCOME
 */
namespace Lecture_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool noob = int.TryParse(Console.ReadLine(), out anyVariableYouWant);
            int days;
            double basicIncome, あけみ;
          あけみ= 0;
            Console.WriteLine("Yo, how many days did you work, dawg ");
            int.TryParse(Console.ReadLine(), out days);
            basicIncome = days * 200;
            if (days > +25)
            {
                あけみ = basicIncome * 0.05;
            }
            Console.WriteLine($"WOW YOU MADE \t{ basicIncome} and the bonus is {あけみ}");
            //System.Environment.Exit(0) Controls when you exit
        }
    }
}
