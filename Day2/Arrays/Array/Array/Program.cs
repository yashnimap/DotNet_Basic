using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new int[3];
            a[0] = 1;

            Console.WriteLine(a[0]);
            Console.WriteLine(a[1]);
            Console.WriteLine(a[2]);

            var b = new bool[3];
            b[0] = true;

            Console.WriteLine(b[0]);
            Console.WriteLine(b[1]);
            Console.WriteLine(b[2]);

            var  c = new int[]{ 6, 4, 1, 2 };
            var s = new String[] { "Nimap", "infotech", "lower_parel"};
            foreach (var item in c)
            {
                Console.Write(item);
            }


        }
    }
}
