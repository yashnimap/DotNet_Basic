using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = 10;
            if (age >= 18)
            {
                Console.WriteLine("You are eligible for voting");
            }
            else if (age <= 10)
            {
                Console.WriteLine("You are to small for voting");

            }

            else
            {
                Console.WriteLine("You are not eligible");
            }
        }
    }
}
