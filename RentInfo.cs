namespace Library
{
    public class RentInfo
    {

        protected string _user;
        protected DateTime _date;
        public string InventoryId {
            get
            { return InventoryId; }


        public RentInfo(Borrower user, DateTime date, string inventoryId)
        {
            _user = user.Name;
            _date = date;
            _inventoryId = inventoryId;
        }
    }
}