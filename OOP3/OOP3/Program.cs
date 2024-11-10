using System;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Petyx petyx = new Petyx();

            animal.MakeSound();
            dog.MakeSound();
            petyx.MakeSound();
        }
    }
}
