using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_Inheritance
{
    interface interface1
    {
        void Test();
        void show();
    }
    interface interface2
    {
        void Test();
        void show();
    }
    internal class MultipleInheritanceTest : interface1, interface2
    {
        public void Test()
        {
            Console.WriteLine("implement method of child class");
        }
        //ANOTHER WAY
        void interface1.show() { Console.WriteLine("INTERFACE 1"); }
        void interface2.show() { Console.WriteLine("INTERFACE 2"); }  

        static void Main(string[] args)
        {
            MultipleInheritanceTest test = new MultipleInheritanceTest();
            //test.Test();

            interface1 I1 = test;
            I1.show();

            interface2 I2 = test;
            I2.show();
        }
    }
}
