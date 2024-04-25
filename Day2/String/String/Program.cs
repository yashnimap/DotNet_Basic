using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var first_name = "yash";
            var last_name = "jadhav";
            string s = string.Format("{0}{1}", first_name, last_name);
            Console.WriteLine(s);

            var full_name = first_name + last_name;
            var a = new int[] { 1, 2, 3, 4, };
            string list = string.Join(", ", a);
            Console.WriteLine(list);

            string s1 = @"yash jadhav
                         nimap infotech
                         lower_oarel";
            Console.WriteLine(s1);

            

            


        }
    }
}

