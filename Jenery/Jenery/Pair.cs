using System;

namespace Jenery
{
    class Pair<T, U>
    {
        private T _value1;
        private U _value2;

        public void SetValue1(T Value)
        { 
            _value1 = Value;
        }
        public T GetValue1()
        { 
            return _value1; 
        }

        public void SetValue2(U Value)
        {
            _value2 = Value;
        }
        public U GetValue2()
        {
            return _value2;
        }
    }
}
