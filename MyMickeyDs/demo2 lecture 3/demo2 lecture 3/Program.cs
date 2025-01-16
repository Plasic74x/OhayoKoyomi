using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2_lecture_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //G can limit the amount of digits seen on a number within one's certain program
            double num = 123232.2345678;
            double num1 = 1232322345.678;
            Console.WriteLine($"num is {num:G}");
            int bhopgod = 25;
            Console.WriteLine($"num is {num1:G5}");
            //if the digit amount is not enough to display the whole value, the G format converts the value to the exponential format
            double num2 = 123.72358;
            Console.WriteLine($"num is {num2:F1}");
            Console.WriteLine($"num is {num2:C}");
            Console.ReadKey();
            //using F we can specify the amount of decimal places　ありがとうございます。
     
            Console.WriteLine($"Displaying value2 in a column with of 20:{bhopgod,20}");

            //D can be used for integral values which allows the nuber of digits used to integers be added using those leading zeros.
            //It makes sure the number equals the amount of digits you wrote before changing it so no change if the original number has more than the D
            //E is used for exponential format  
            //C is for currency formatting with a dollar sign in front if the country is different, the currency symbol is also different
            //P is for percent
            //X is for hexadecimal
        }
    }
}
