using System;

namespace OOP1
{
    class BankAccount
    {
        private uint _balance = 0;

        public uint ShowBalance()
        { 
            return _balance; 
        }

        public void ReplenishMoney(uint Money)
        {
            _balance += Money;
        }

        public uint TakeMoney(uint Money)
        {
            if (Money <= _balance)
            {
                _balance -= Money;
                return Money;
            }

            return 0;
        }
    }
}
