using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //boxing
            int number = 10;
            Object obj = number;
            //or
            Object obj2 = 10;

            //unboxing
            Object obj1 = 20;
            int number2 = (int)obj1;

            Console.WriteLine(number2);

            //var list = new ArrayList();
            //list.Add(1);
            //list.Add("Yash");
            //list.Add(DateTime.Today);

            //var n = (int)list[1];
            //Console.WriteLine(n);//invalid cate exception
        }
    }
}
