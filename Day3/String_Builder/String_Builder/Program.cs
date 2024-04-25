using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append('-', 10);
            builder.AppendLine();
            builder.Append("header");
            builder.AppendLine();
            builder.Append('-', 10);

            builder.Remove(0, 10);
            builder.Insert(0,new string('-', 10));  
            Console.WriteLine(builder);
        }
    }
}
