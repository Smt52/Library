namespace Library
{
    public class BookWrapper : IBorrow, IReturn
    {
        protected List<Librarian> _librarians;
        protected List<RentInfo> _rents;
        protected Book book;
        protected string _isbn;
        private readonly int Count;
        protected int _countOfAvailable;
        private string _location;

        public BookWrapper(Book book, string isbn, int count, int countOfAvailable, string location)
        {
            _librarians = new List<Librarian>();
            _rents = new List<RentInfo>();
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
            if (_countOfAvailable == 0)
            {
                return false;
            }
            if (!(Count == _countOfAvailable))
            {
                _countOfAvailable++;
            }

            return true;
        }

        public int ReturnBook(IReturn @return)
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

        public void AddLibrarian(Librarian librarian)
        {
            _librarians.Add(librarian);
        }

        public void RemoveLibrarian(Librarian librarian)
        {
            _librarians.Remove(librarian);
        }

        public void FewerBook()
        {
            if (_countOfAvailable < 2)
            {
                foreach (var librarian in _librarians)
                {
                    librarian.NotifyBookCount(this);
                }
            }
        }

        public string GetBookName()
        {
            return book.GetBookTitle();
        }
    }
}