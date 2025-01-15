using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * This program allows you to input the number of bits at your discretion and sorts out the bits using the most possible gigabytes, then megabytes, then kilobytes, and finally the
 * remaining bits are sold in individual bytes using division and remainders in order to calculate it.
 * INPUT numBytes
 * CALCULATE gigaBytes = (numBytes / 1073741824);
   CALCULATE   megaBytes = ((numBytes %  1073741824)/1048576);
   CALCULATE  kiloBytes = (((numBytes %  1073741824)%1048576)/1024);
   CALCULATE     bytes = (((numBytes %  1073741824)%1048576)%1024);
    OUTPUT gigaBytes
    OUTPUT megaBytes
    OUTPUT kiloBytes
    OUTPUT bytes
    OUTPUT subTotal
    CALCULATE totalebeforeGST= Subtotal + 911 Access + System Access
    OUTPUT totalbeforeGST
    CALCULATE GST = totalbeforeGST + totalbeforeGST*0.05
    OUTPUT GST
    OUTPUT total = totalbeforeGST + GST
    End of program
 * */
namespace Lab_1___Fall2024_Cell_Phone_Data_Cost_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long numBytes;
            long gigaBytes, megaBytes, kiloBytes, bytes;
            double subTotal,totalBeforeGST,GST;
            Console.CursorLeft = 45;
            Console.WriteLine("Lab 1 - Cell Phone Data Cost Calculator");
            Console.WriteLine("");
            Console.WriteLine("Enter the number of bytes used:");
            Console.SetCursorPosition(32, 2);

            long.TryParse(Console.ReadLine(), out numBytes);

            //Rounding off the Bytes
            gigaBytes = (numBytes / 1073741824);
            megaBytes = ((numBytes %  1073741824)/1048576);
            kiloBytes = (((numBytes %  1073741824)%1048576)/1024);
            bytes = (((numBytes %  1073741824)%1048576)%1024);
            //Sets the color for the letters in this part
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Amount\t\t Unit\t\t Cost/Unit\t Total");
            Console.WriteLine();
            Console.ResetColor();

            //Displays the number of each type of byte used including the cost per each and the total
            Console.WriteLine($"{gigaBytes}\t\t GB \t\t $12.00\t\t ${12.00*gigaBytes:F2}");
            Console.WriteLine($"{megaBytes}\t\t MB \t\t $0.25\t\t ${0.25 * megaBytes:F2}");
            Console.WriteLine($"{kiloBytes}\t\t KB \t\t $0.02\t\t ${0.02 * kiloBytes:F2}");
            Console.WriteLine($"{bytes}\t\t KB \t\t $0.02\t\t ${0.01 * bytes:F2}");
            Console.WriteLine("\t\t \t\t \t\t ----------");

            //The subtotal
            subTotal = 12.00 * gigaBytes + 0.25 * megaBytes + 0.02 * kiloBytes + 0.01 * bytes;
            Console.WriteLine($"SubTotal\t\t \t\t \t ${subTotal:F2}");

            //911 access fee display
            Console.WriteLine();
            Console.WriteLine("911 Access Fee\t\t \t\t \t $0.95");

            //System Access Fee display
            Console.WriteLine();
            Console.WriteLine("System Access Fee\t\t \t\t $6.95");

            //Total Before GST display
            Console.WriteLine();
            totalBeforeGST = subTotal + 0.95 + 6.95;
            Console.WriteLine($"Total before GST\t\t \t\t {totalBeforeGST:F2}");

            //Gst amount display
            GST = totalBeforeGST * 0.05;
            Console.WriteLine($"GST\t\t \t\t \t\t {GST:F2}");
            Console.WriteLine("\t\t \t\t \t\t ----------");
            //total Cost
            Console.WriteLine($"Total for Data:\t\t \t\t \t {GST+totalBeforeGST:F2}");

            Console.WriteLine();
            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();//End of Program
        }
    }
}
