using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
internal class Program
{
    static void Main(string[] args)
    {
        string s = "YASH JADHAV";
        //var s1 = s.ToLower();   
        //var s3 = s.ToUpper();   

        //Console.WriteLine(s.Trim());

        //var s2 = "1234";
        //Console.WriteLine(int.Parse(s2));

        //Console.WriteLine(s.IndexOf('H'));

        //var namesplit = s.Split(' ');
        //Console.WriteLine("first_name : " + namesplit[0]);
        //Console.WriteLine("las_name :"+ namesplit[1]);

        //var a = s.Replace("YASH", "Mohan");
        //Console.WriteLine(a);

        string str = "25";
        var age = Convert.ToByte(str);
        Console.WriteLine(age);

        double d = 45.8d;
        d.ToString();
        Console.WriteLine(d);
    }
}
}
