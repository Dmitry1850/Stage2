using System;

namespace Jinery4
{
    internal class Program
    {
        static void Swap<T>(ref T value1, ref T value2)
        { 
            T swap = value1;
            value1 = value2;
            value2 = swap;
        }
        static void Main(string[] args)
        {
            int value1 = 2;
            int value2 = 3;

            Swap(ref value1, ref value2);

            Console.WriteLine($"{value1} {value2}");
        }
    }
}
