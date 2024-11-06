namespace SOLID2
{
    class FixedAmountDiscount : Discount
    {
        public FixedAmountDiscount(string id)
        { 
            _id = id;
        }

        private string _id;

        public string GetID()
        { 
            return _id;
        }
    }
}
