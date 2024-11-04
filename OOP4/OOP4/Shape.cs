using System;

namespace OOP4
{
    abstract class Shape
    { 
        public abstract void GetArea();
    }

    class Circle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("Circle");
        }
    }

    class Rectangle : Shape
    {
        public override void GetArea()
        {
            Console.WriteLine("Rectangle");
        }
    }
}
