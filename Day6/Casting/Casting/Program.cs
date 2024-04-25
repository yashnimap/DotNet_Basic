using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Casting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var text = new Text();
            //shape shape = text;

            //text.width = 100;
            //text.height = 200;

            //Console.WriteLine(text.width);
            //Console.WriteLine(text.height);

            //downcasting
            Shape shape = new Text();
            Text text = (Text)shape;
        
        }
    }
}
