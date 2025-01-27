//Program: ICA1 -Fall2024- Energy Drink Calculator
//Description: Assignment where the program calculates the buying energy drinks in singles, packs of 6 and dozens
//Date: Sep. 15/2024
//Author: Simon Cui
//Course: CMPE1300
//Class: A03
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Psuedocode
 * INPUT energyDrinkName
 * INPUT drinkCans
 * INPUT dozenCansCost
 * INPUT 6PackCansCost
 * INPUT singleCanCost
 * CALCULATE: dozenCans = drinkcans/12
 * CALCULATE: 6PackCans = (drinkcans/12)/6
 * CALCULATE: singleCans = ((drinkcans/12)%6)
 * CALCULATE cost = (dozenCans*dozenCansCost+6PackCans*6packCansCost+singleCans*singleCanCost)
 * dozenCans
 * OUTPUT energyDrinkName
 * OUTPUT dozenCans
 * OUTPUT 6PackCans
 * OUTPUT singleCans
 * OUTPUT 6PackCans
 * OUTPUT singleCans
 * OUTPUT cost
 */
namespace ICA2_Fall2024__Energy_Drink_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorLeft=60;
            Console.WriteLine($"");
        }
    }
}
//int result1
//int value4=5
//int value4+=5
//Console.WriteLine($"The initial value of value 4 is: {value4}")
//dd