namespace Library
{
   
    public class BookWrapper:IBorrow,IReturn
    {
        protected List<RentInfo> rents;
        protected Book book;
        protected string _isbn;
        private readonly int Count;
        protected int _countOfAvailable;
        private string _location;

        public BookWrapper(List<RentInfo> rents, Book book, string isbn, int count, int countOfAvailable, string location)
        {
            this.rents = rents;
            this.book = book;
            _isbn = isbn;
            _countOfAvailable = count;
            Count = count;
            _location = location;
        }

        public string Location()
        {
            if (!Availability())
            {
                _location = " No books available.";
                return _location;
            }

            return _location;

        }

        public bool Availability()
        {
            if(_countOfAvailable == 0)
            {
                return false;
            }
            if (!(Count == _countOfAvailable))
            {
                _countOfAvailable++;
            }

            return true;
        }
         public int ReturnedBook(IReturn @return)
        {
            if (@return.Return())
            {
                _countOfAvailable++;
                return _countOfAvailable;
            }
            return 0;
        }
        public bool Return()
        {
            return true;
        }

    }
}
