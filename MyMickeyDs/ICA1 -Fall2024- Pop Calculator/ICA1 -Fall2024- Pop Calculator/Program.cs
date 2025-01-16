//Program: ICA1 -Fall2024- Pop Calculator
//Description: Assignment where the program calculates the total cost of pop 
//Date: Sep. 15/2024
//Author: Simon Cui
//Course: CMPE1300
//Class: A03






using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA1__Fall2024__Pop_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pop;//The amount of pop cans bought
            string buy;//Used to input the amount of cans from string to integer
            string askCost;//Used to input the cost to an integer
            int cost;//The integer of the cost
            Console.CursorLeft = 60;
            Console.WriteLine("ICA01 - Simon Cui");

            Console.WriteLine("Enter the number of cans of pop to purchase:");
            buy = Console.ReadLine();
            int.TryParse(buy, out pop);
            Console.WriteLine("Enter the cost per can:");
            askCost = Console.ReadLine();
            int.TryParse(askCost, out cost);


            Console.WriteLine($"The GST is ${cost * 0.05*pop}");//The gst
            Console.WriteLine($"The total cost is ${(cost * 0.05+cost)*pop}");//The total cost
            Console.WriteLine("Press enter to continue");//end
            Console.ReadLine();
        }
    }
}
//int age;
//string input;
//int person1;
//int person2;

//Console.WriteLine("how old are you  little one:");
////Alternate thing to do
////   input = Console.ReadLine();
////int.TryParse(input, out age);
//int.TryParse(Console.ReadLine(), out age);

//Console.WriteLine($"The age of the jebus is: {age}");
//Console.WriteLine("How many poke balls does person one need?");
//int.TryParse(Console.ReadLine(), out person1);
//Console.WriteLine("How many pokemon balls does person two need");
//int.TryParse(Console.ReadLine(), out person2);
//Console.WriteLine($"Dawg, you need {person1 + person2} poke balls");
//Console.WriteLine("if u using debug press any key to exit (smile)");
//Console.ReadKey();