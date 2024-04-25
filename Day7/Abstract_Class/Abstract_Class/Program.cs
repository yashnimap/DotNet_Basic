using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{

    abstract class abcParent
    {
        public void add(int x,  int y) {
            Console.WriteLine(x+y);
        }  

        public void sub(int x, int y)
        {
            Console.WriteLine(x-y);
        }

        public abstract void mul(int x, int y); 
        public abstract void div(int x, int y);
    }

    class abcChild : abcParent
    {
        public override void mul(int x, int y)
        {
            Console.WriteLine(x*y);
        }

        public override void div(int x, int y)
        {
            Console.WriteLine(x / y);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
                abcChild abcChild = new abcChild();
                abcChild.add(1, 2);
                abcChild.sub(1, 2);
                abcChild.mul(1, 2);

        }
    }
}
