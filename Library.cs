namespace Library
{
    public class Library
    {
        protected Dictionary<string, BookWrapper> _bookWrapper = new Dictionary<string, BookWrapper>();

        public string Rent(string key)
        {
            if (!Borrow(GetBook(key)))
            {
                return "There is no such book.";
            }

            return "Books is lented out successfully.";
        }

        private BookWrapper GetBook(string key)
        {
            if (!(_bookWrapper.ContainsKey(key)))
            {
                return null;
            }
            return _bookWrapper[key];
        }

        private bool Borrow(IBorrow borrow)
        {
            if (!borrow.Availability())
            {
                return false;
            }
            return true;
        }

        public string Return(IReturn @return)
        {
            if (!@return.Return())
            {
                return "Book cannot retrieved.";
            }

            return "Book is retrieved successfully.";
        }
    }
}