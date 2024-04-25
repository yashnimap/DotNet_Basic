using System.Collections.Generic;

namespace Fields
{
    public class Customer {
        public int id;
        public string name;
        public readonly List<Order> orders;

        public Customer() { 
            orders = new List<Order>(); 
        }   
        public Customer(int id)
        {
            this.id = id;
        }

        public Customer(int id, string name)
            : this(id)
        { 
            this.name = name;
        }

        public void addobj(Order obj)
        { 
           orders.Add(obj); 

        }
    }
}
