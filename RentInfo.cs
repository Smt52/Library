namespace Library
{
    public class RentInfo
    {

        protected string _user;
        protected DateTime _date;
        protected string _inventoryId;


        public RentInfo(Borrower user, DateTime date, string inventoryId)
        {
            _user = user.Name;
            _date = date;
            _inventoryId = inventoryId;
        }
    }
}