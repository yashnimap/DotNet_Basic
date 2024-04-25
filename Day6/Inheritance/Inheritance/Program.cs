using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var text = new Text();
            text.width = 120;
            text.height = 200;
            Console.WriteLine(text.width);
            Console.WriteLine(text.height);
            text.Copy();
        }
    }
}
