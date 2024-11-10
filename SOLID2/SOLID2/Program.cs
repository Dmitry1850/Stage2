using System;

namespace SOLID2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Discount discount = new Discount();
            PercentrageDiscount percentrageDiscount = new PercentrageDiscount();
            FixedAmountDiscount fixedAmountDiscount = new FixedAmountDiscount("69");

            discount.Calculate();
            percentrageDiscount.SetProcent(13);
            Console.WriteLine(percentrageDiscount.ReturnRealProcent(228));
        }
    }
}
