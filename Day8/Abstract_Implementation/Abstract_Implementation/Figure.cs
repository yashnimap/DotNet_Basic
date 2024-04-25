using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Implementation
{
    public abstract class Figure
    {
        public double height, width, radius;
        public const float Pi = 3.14f;

        public abstract double getArea();


        
    }
    public class Rectangle : Figure {
        public Rectangle(double width, double height) {
            this.width = width;     
            this.height = height;   
        }

        public override double getArea()
        {
            return width*height;
        }
    }
    public class Circle : Figure { 
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double getArea()
        {
            return Pi*radius*radius;
        }
    }    

    public class Cone : Figure
    {
        public Cone(double radius, double height) { 
            this.radius=radius; 
            this.height=height;
        }

        public override double getArea()
        {
            return Pi*radius*(radius+Math.Sqrt(height*height+radius*radius));
        }
    }

    public class Test_Figure
    {
        static void Main(string[] args)
        {
            Rectangle radius = new Rectangle(4.5,2.5);
            var result = radius.getArea();
            Console.WriteLine(result);

            Circle circle = new Circle(4.5);
            var result1 = circle.getArea();
            Console.WriteLine(result1);

            Cone cone = new Cone(3.5, 1.5);
            var result3 = cone.getArea();
            Console.WriteLine(result3);

            Console.ReadLine();
        }
    }
}
