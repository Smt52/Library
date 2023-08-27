namespace Library
{
    public class Author
    {
        protected string _name;
        protected string _surname;
        protected List<Book> _books;


        public Author(string name, string surname, List<Book> books)
        {
            _name = name;
            _surname = surname;
            _books = books;
        }
    }
}