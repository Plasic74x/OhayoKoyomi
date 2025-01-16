/*
 * 
 * 
 * 
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture4Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //You can chain variables yknow? オリジナル
            int num, value;
            int オリジナル;
            num = value = 0;// both num and value are ASIGNED 0
            Console.WriteLine("Illustrating Ordder of Precedence");
            Console.WriteLine("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");
            Console.WriteLine("The remainder operator");
            Console.WriteLine($"The remainder of 17 divided by 5 is {17 % 5}");
            Console.WriteLine("WWorking with pre-increment and pre-decrement operators");
            int tansome = 5;
            int peppa = ++tansome;//adds one to the result
            Console.WriteLine($"The value of result is:{peppa} and that of value 3 is: {tansome}");
            Console.WriteLine();
            オリジナル = 90;
            num = 5 + 6 + 2;
            value = (5 + 6) * 2;
            double inch = 0.0;
            double cm = 0.0;
            int val1 = 27;
            double val2 = 27;  
            //taking in the input of inch and use it as an expression
            Console.WriteLine("Input the number of inches you wish to convert:");
            double.TryParse(Console.ReadLine(), out inch);
            Console.WriteLine($"{inch} inches is equivalent to {inch * 2.54} cms"); 
            Console.WriteLine($"The result of 5+6*2 is: {num}and 11*2 is {value} and rocket damage is {オリジナル}");
            Console.WriteLine($"The result of val1/2 is {val1 / 2}");
            Console.WriteLine($"The result of val2/2 is {val2 / 2}");
            Console.WriteLine($"The result of val2/2 is {val2 / 2.0}");//need to add the decimal in the end
        }
    }
}
