using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overloading
{
    public class Parent
    {
        public void show()
        {
            Console.WriteLine("parent show method is called");
        }

        public virtual void Test()
        {
            Console.WriteLine("Parent text method is called");
        }
    }

    public class Child : Parent
    {
        public void show (int i) {
            Console.WriteLine("child show method is called");
        }
        public override void Test()
        {
            Console.WriteLine("hii");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent c = new Child();
            c.show();
            //c.show(1);
            c.Test();

        }
    }
}
