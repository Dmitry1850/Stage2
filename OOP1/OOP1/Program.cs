using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount TomBankAccount = new BankAccount();

            TomBankAccount.ReplenishMoney(200);
            Console.WriteLine(TomBankAccount.TakeMoney(33));
            Console.WriteLine(TomBankAccount.ShowBalance());
        }
    }
}
