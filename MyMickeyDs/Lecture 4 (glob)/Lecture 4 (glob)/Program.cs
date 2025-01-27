using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_4__glob_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int value2 = 5;
            //double x1 = 2.5;
            //int value3;
            //int value4;
            //value3 = (int)(value2 * x1);
            //Console.WriteLine($"The result of (int) ({value2}*{x1} is: {value3}");
            //value4 = value2 * (int)x1;
            //Console.WriteLine($"The result of {value2}*(int){x1}) is: {value4}");
            //char letter = 'a';
            //int newInt = letter;
            //Console.WriteLine($"The value of letter is {letter} while that of newInt is {newInt}");
            //letter = (char)65;
            //Console.WriteLine($"The value of char65 is {letter}");

            double x = 15.56;
            Console.WriteLine($"The result of castin x to int then multiply by 1 is {(int)x} by 10");
            Console.WriteLine($"The result of multiplying x by 10 is then casting to int is {(int)(x * 10)}");
            double y = 122;
            Console.WriteLine($"The result of casting y to double then divide by 11 is {(double)y/11:F2}");
            Console.WriteLine($"The result of dividing y by 11 then casting to double is is {(double)(y / 11):F2}");

            //Type casting
        }
    }
}
