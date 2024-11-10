using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Venchile venchile = new Venchile();
            venchile.SetModelName("PAROVOZ");
            Console.WriteLine(venchile.ShowModelInfo());

            Car car = new Car();
            car.PistonsMass = -7;
            Console.WriteLine(car.PistonsMass);
        }
    }
}
