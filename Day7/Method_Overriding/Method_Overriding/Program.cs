using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    public class Animal
    {
        public virtual void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
    }

    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("Dog is eating");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var dog = new Dog();
            dog.Eat();
           
        }
    }
}
