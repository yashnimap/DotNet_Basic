using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var emp = new Employee(1, 2345.0, "Yash", "developer", "dotnet", "lower_parel");
            Console.WriteLine("Emp no :" + emp[0]);
            Console.WriteLine("salary :" + emp[1]);
            Console.WriteLine("name :" + emp[2]);
            Console.WriteLine("job :" + emp[3]);
            Console.WriteLine("departname :" + emp[4]);
            Console.WriteLine("location :" + emp[5]);
            Console.ReadLine(); 
            
        }
    }
}
