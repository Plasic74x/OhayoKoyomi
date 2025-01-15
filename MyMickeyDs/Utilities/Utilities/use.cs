using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    public class use
    {
        static public void GetValue(out int number, string output)
        {
            int valid = 0;
            number = 0;
            while (valid == 0)
            {
                Console.Write(output);
                bool check = int.TryParse(Console.ReadLine(), out number);
                if (!check)
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    valid = 1;
                }


            }

        }
        static public void GetValue(out int number, string output, int min)
        {
            int valid = 0;
            number = 0;
            while (valid == 0)
            {

                Console.Write(output);
                bool check = int.TryParse(Console.ReadLine(), out number);
                if (!check)
                {
                    Console.WriteLine("Invalid value");
                }
                else if (number < min)
                {
                    Console.WriteLine($"Please enter a positive value {min} or greater");
                }
                else
                {
                    valid = 1;
                }


            }

        }
        static public void GetValue(out int number, string output, int min, int max)
        {
            int valid = 0;
            number = 0;
            while (valid == 0)
            {

                Console.Write(output);
                bool check = int.TryParse(Console.ReadLine(), out number);
                if (!check)
                {
                    Console.WriteLine("Invalid value");
                }
                else if (number < min || number > max)
                {
                    Console.WriteLine($"Please enter a positive value {min} or greater and {max} and less");
                }
                else
                {
                    valid = 1;
                }


            }

        }
        static public void GetValue(out double number, string output)
        {
            int valid = 0;
            number = 0;
            while (valid == 0)
            {

                Console.Write(output);
                bool check = double.TryParse(Console.ReadLine(), out number);
                if (!check)
                {
                    Console.WriteLine("Invalid value");
                }
                else
                {
                    valid = 1;
                }


            }

        }
        static public void GetValue(out double number, string output, int min)
        {
            int valid = 0;
            number = 0;
            while (valid == 0)
            {

                Console.Write(output);
                bool check = double.TryParse(Console.ReadLine(), out number);
                if (!check)
                {
                    Console.WriteLine("Invalid value");
                }
                else if (number < min)
                {
                    Console.WriteLine($"Please enter a positive Double value {min} or greater");
                }
                else
                {
                    valid = 1;
                }


            }

        }
        static public void GetValue(out double number, string output, int min, int max)
        {
            int valid = 0;
            number = 0;
            while (valid == 0)
            {

                Console.Write(output);
                bool check = double.TryParse(Console.ReadLine(), out number);
                if (!check)
                {
                    Console.WriteLine("Invalid value");
                }
                else if (number < min || number > max)
                {
                    Console.WriteLine($"Please enter a positive integer value {min} or greater and {max} and less");
                }
                else
                {
                    valid = 1;
                }


            }

        }

    }
}
