using System;
using System.Collections.Generic;

namespace genery5
{
    class ListStorage<T> : IStorage<T>
    {
        private List<T> values;   
        public void Add(T value)
        {
            values.Add(value);
        }

        public T Get(int element)
        {
            return values[element];
        }
    }
}
