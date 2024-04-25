using System;

namespace Constrctor
{
    public class car : Vehicle 
    {
        public car(string registrationNumber) 
             : base(registrationNumber)        
        {
            Console.WriteLine("car is being initialize. {0}",registrationNumber);
        }
    }
}
