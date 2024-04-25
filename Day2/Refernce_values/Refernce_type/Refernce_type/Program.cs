using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refernce_type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new int[] { 1, 2 };
            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

        }
    }
}
