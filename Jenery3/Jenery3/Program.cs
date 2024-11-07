using System;

namespace Jenery3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<string> repository = new Repository<string>();

            repository.SetElement("qq");
            Console.WriteLine(repository.GetElementOnIndex(0));
        }
    }
}
