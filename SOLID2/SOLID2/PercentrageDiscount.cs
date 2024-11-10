namespace SOLID2
{
    class PercentrageDiscount : Discount
    {
        public int Procent { get; private set; }

        public void SetProcent(int procent)
        {
            if (procent > 0 && procent < 50)
                Procent = procent;
            
        }

        public int ReturnRealProcent(int summ)
        {
            return (summ * Procent / 100);
        }
    }
}
