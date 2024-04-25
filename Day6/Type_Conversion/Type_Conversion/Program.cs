using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Conversion
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            //Explicit type conversion
            int b = 256;
            byte i = (byte)b;

            Console.WriteLine(i);

            //implicit type conversion
            byte b1 = 255;
            int i1 = b1;
            Console.WriteLine(i1);

            string s = "1234";
            //int i2 = Convert.ToInt32(s);
            int i2 = int.Parse(s);
            Console.WriteLine(i2);

            int a = 5678;
            string s1 = a.ToString();
            Console.WriteLine(s1);

        }
    }
}
