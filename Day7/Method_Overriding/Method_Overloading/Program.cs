using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Parent
    {
        public void show() {
            console.WriteLine("parent show method is called");
        }

        public void Test()
        {
            console.WriteLine("Parent text method is called");
        }
    }

    public class Child : Parent
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var c = new Child();
            c.Test();
            c.show();
        }
    }
}
