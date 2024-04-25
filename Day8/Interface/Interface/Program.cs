using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface ITestinterface1
    {
        void add(int a, int b);
    }

    interface ITestinterfcae2 : ITestinterface1
    {
        void sub(int a, int b);

    }

    public class implementationClass : ITestinterface1, ITestinterfcae2
    {
        public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public void sub(int a, int b)
        {
            Console.WriteLine(a-b);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            implementationClass impclass = new implementationClass();
            ITestinterface1 testinterface1 = impclass; // interface reference
            impclass.add(1, 2);
            impclass.sub(3, 4);
        }
    }
}
