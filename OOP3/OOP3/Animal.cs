using System;
using System.Runtime.InteropServices;

namespace OOP3
{
    class Animal
    {
        virtual public void MakeSound()
        {
            Console.WriteLine("ЩЩЩЩ");
        }
    }

    class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Гав");
        }
    }
    class Petyx : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Ержан вставай!!!");
        }
    }
}
