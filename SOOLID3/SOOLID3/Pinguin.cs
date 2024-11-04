using System;

namespace SOOLID3
{
    class Pinguin : Bird
    {
        public override void Fly()
        {
            Console.WriteLine("Пингвин не умеет летать!");
        }
    }
}
