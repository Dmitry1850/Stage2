using System;
using System.Collections.Generic;

namespace genery5
{
    class ListStorage<T> : IStorage<T>
    {
        private List<T> _values = new List<T>(2);   
        public void Add(T value)
        {
            _values.Add(value);
        }

        public int Get(T element)
        {
            return _values.IndexOf(element);
        }
    }
}
