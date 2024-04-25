using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new[] { 31, 12, 63, 4, 15, 56 };
            Console.WriteLine("length : " + a.Length);

            //Console.WriteLine("index : " + Array.IndexOf(a, 12));
            //var index = Array.IndexOf(a,63);
            //Console.WriteLine(index);

            //Array.Clear(a, 2, 4);
            Array.Sort(a);

            Array.Reverse(a);
            foreach (var x in a) Console.WriteLine(x);
        }
    }
}
