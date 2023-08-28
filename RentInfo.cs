namespace Library
{
    public class RentInfo
    {
        protected string _borrower;
        protected DateTime _date;
        protected string _inventroyId;

        public RentInfo(string borrower, DateTime date, string inventoryId)
        {
            _borrower = borrower;
            _date = date;
            _inventroyId = inventoryId;
        }
    }
}