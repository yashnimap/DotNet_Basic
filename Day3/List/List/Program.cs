using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = new List<int>() { 12,4,12, 6};
            a.Add(10);
            a.AddRange(new int[3] { 11,12,13});

            //foreach (int i in a) { Console.WriteLine(i); }

            //Console.WriteLine(a.IndexOf(8));
            //Console.WriteLine(a.LastIndexOf(8));
            //Console.WriteLine(a.Count);

            //a.Remove(11);

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] == 12)
                {
                    a.Remove(a[i]);
                }

            }


            foreach (int i in a)
            {
                Console.WriteLine(i);
            }

            a.Clear();  
            Console.WriteLine("length : "+a.Count);

        }
    }
}
