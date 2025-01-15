using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_5_pt_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 5, y = 6;

            Console.WriteLine($"x<y is: {x < y}");
            Console.WriteLine($"x==y is {x == y}");
            Console.WriteLine("Domain Expansion");
            int behrooz;
            int Bloodmachine;
            Random particleCollider = new Random();
            Bloodmachine = particleCollider.Next(10);
            Console.WriteLine($"Bloodmachine reached {100* Bloodmachine} Dpm");
            Console.Write("How many ppl with high scout acc do you meet?");
            int.TryParse(Console.ReadLine(), out behrooz);
            if (behrooz > 9)
            {
                Console.WriteLine("dam ur so cool...");

            }
            if (behrooz < 9)
            {
                Console.WriteLine("I guess you've met goldenstaff before");
            }
            {

            }
        }
    }
}
