using System;

namespace genery5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListStorage<int> listStorage = new ListStorage<int>();

            listStorage.Add(3);
            listStorage.Add(3);
            listStorage.Add(3);
            listStorage.Add(6);

            int result = listStorage.Get(6);

            if (result < 0)
            {
                Console.WriteLine("Такого элемента нет!");
            }
            else
            {
                Console.WriteLine($"Элемент находится под индексом: {result}");
            }
        }
    }
}
