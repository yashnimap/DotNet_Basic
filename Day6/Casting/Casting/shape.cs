using System;

namespace Casting
{
    public class shape
    {
        public int height {  get; set; }
        public int width { get; set; }
        public int x { get; set; }  
        public int y { get; set; }  

        public void draw()
        {
            Console.WriteLine("shape is drawing");
        }
    }
}
