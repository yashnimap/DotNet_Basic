using System;

namespace Constrctor
{
    public class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationnumber)
        {
            _registrationNumber = registrationnumber;
            Console.WriteLine("vehicle is being initialize {0}",registrationnumber);
        }
       
        
        //public Vehicle()
        //{
        //    Console.WriteLine("vehicle is being initialize");
        //}
    }
}
