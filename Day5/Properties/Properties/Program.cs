using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{


    public class Person
    {
        private int id;
        private string name;
        private int age;
        public char c;

        public int  getId()
        {
            return id;
        }

        public void setId(int id)
        {
            this.id = id;
        }
        public string getName() { 
            return name;

        }
        public void setName(string name) { 
            this.name = name;   
        }    
        public int getAge()
        {
            return age; 
        }

        public void setAge(int age) { 
            this.age = age; 
        }


    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //var person = new Person();
            //person.setName("Yash");
            //person.setAge(23);
            //person.setId(1);

            //Console.WriteLine(person.getId());
            //Console.WriteLine(person.getName());
            //Console.WriteLine(person.getAge());

            var properties = new Properties();
            properties.Money = 1;
            Console.WriteLine(properties.Money);

            Console.WriteLine(properties.Radius);
        }
    }
}
