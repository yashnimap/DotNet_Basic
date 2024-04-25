using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Classes
{
    sealed class Parent
    {
        public void show()
        {
            Console.WriteLine("Parent class method");
        }
    }

    public class Child : Parent //Error cannot derive from sealed type Parent
    {
        public void show1()
        {
            Console.WriteLine("chil class method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();  
            child.show();
        }
    }
}
