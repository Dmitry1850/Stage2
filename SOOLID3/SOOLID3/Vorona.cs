using System;

namespace SOOLID3
{
    class Vorona : Bird, IFly
    {
        public void Fly()
        {
            Console.WriteLine("Птица летит");
        }
    }
}
