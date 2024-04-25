using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fields
{

    internal class Program
    {
        static void Main(string[] args)
        {
            //var customer = new Customer(1);
            //customer.orders.Add(new Order());
            //customer.orders.Add(new Order());

            //Console.WriteLine(customer.orders.Count);

            var customer = new Customer();
            customer.addobj(new Order());
            customer.addobj(new Order());
            Console.WriteLine(customer.orders.Count);


        }
    }
}
