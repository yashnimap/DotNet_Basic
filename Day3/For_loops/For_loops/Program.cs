using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var a = 10;
            //for (int i = 0; i < a; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //for (int i = a; i >= 1; i--)
            //{
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}


            //var s = "nimap infotech";
            //for (int i = 0; i < s.Length; i++)
            //{
            //    Console.Write(s[i]);
            //}
            //Console.WriteLine();

            //foreach(var character  in s)
            //{
            //    Console.Write(character);
            //}
            //Console.WriteLine();


            var a = new int[] { 3, 2, 6, 2 };
            foreach (var num in a)
            {
                Console.WriteLine(num);
            }


        }
    }
}
