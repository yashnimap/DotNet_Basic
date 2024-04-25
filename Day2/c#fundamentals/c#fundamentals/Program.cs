using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_fundamentals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.first_name = "john";
            john.last_name = "clay";

            john.indroduction();
            Calculator c = new Calculator();
            Console.WriteLine(c.add(3,7));
        }
    }
}
