using System;

namespace Jenery3
{
    class Repository<T> where T : class
    {
        public Repository(int Length = 2)
        {
            values = new T[Length];
        }

        private T[] values;

        public void SetElementOnIndex(int index, T value)
        {
            if (index >= 0 && index < values.Length)
            {
                values[index] = value;
            }
            else 
            {
                Console.WriteLine("Такого индекса нет!");
            }
        }

        public T GetElementOnIndex(int index)
        {
            if (index >= 0 && index < values.Length)
            {
                return values[index];
            }
            else
            {
                throw new Exception("NoIndex");
            }
        }
    }
}
