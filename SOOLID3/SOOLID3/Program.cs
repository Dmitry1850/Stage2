using System;

namespace SOOLID3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pinguin pinguin = new Pinguin();
            Vorona vorona = new Vorona();

            pinguin.Walk();
            vorona.Fly();
           
        }
    }
}
