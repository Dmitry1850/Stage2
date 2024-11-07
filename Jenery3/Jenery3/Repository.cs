using System;
using System.Collections.Generic;

namespace Jenery3
{
    class Repository<T> where T : class
    {
        public Repository(int Length = 2)
        {
            values = new List<T>(Length);
        }

        private List<T> values;

        public void SetElement(T value)
        {
            values.Add(value);
        }

        public T GetElementOnIndex(int index)
        {
            if (index >= 0 && index < values.Count )
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
