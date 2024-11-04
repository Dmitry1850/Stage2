namespace SOLID2
{
    class PercentrageDiscount : Discount
    {
        public int Procent { get; set; }

        public int ReturnRealProcent(int summ)
        {
            return (summ * Procent / 100);
        }
    }
}
