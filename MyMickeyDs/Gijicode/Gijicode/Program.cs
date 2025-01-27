/*
 * Input item_price
 * Input Number_of_Items
 * Input gst_rate
 * Calculate: gst= gstrate/100
 * Calculate: cost=(no_of_items x item_price x (1+gst))
 * Output number_of_items
 * Output item_price
 * Output gst_rate
 * Output cost
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Gijicode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double itemPrice;
            Console.Write("What's the price of each item homie?");
            double.TryParse(Console.ReadLine(), out itemPrice);

            int numItems;
            //inputs
            Console.WriteLine("Enter number of units purchased:");
            int.TryParse(Console.ReadLine(), out numItems);
            double gstRate;
            Console.WriteLine("Enter the GST Rate being charged:");
            double.TryParse(Console.ReadLine(), out gstRate);
            //calcs
            double gst = gstRate / 100;
            double cost = numItems * itemPrice * (1 + gst);
            //OUTPUT
            //Just sum formatting conveniently used to align all the text in a very nice way :)
            Console.WriteLine($"{"Number of Items purchased",-30} {numItems}");
            Console.WriteLine($"{"ItemPrice",-30}{itemPrice:C}");
            Console.WriteLine($"{"gst Rate",-30}{gstRate}%");
            Console.WriteLine($"{"Total Cost",-30}{cost:C}");
            Console.WriteLine($"\"You're a noob kid\"");
            // \n is a newline thingy
            // \b used to make the cursor simply start to move back one space
        }
    }
}
