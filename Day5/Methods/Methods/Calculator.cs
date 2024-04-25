using System;

namespace Methods
{
    internal partial class Program
    {
        public class Calculator
        {
            public int result;
            public void add(int a , int b)
            {
                result = a + b;
                display();
            }

            public void substrct(int a, int b)
            { 
                result =  a - b; 
                display();
            }

            public void multiplicton(int a, int b)
            {
                result = a * b;
                display();
            }

            public void display()
            {
                Console.WriteLine(result);
            }




        }
    }
}
