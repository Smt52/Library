namespace Library
{
    public class Book
    {
        private Author _author;
        private string _title;
        private List<Genre> _genre;

        public Book(Author author, string title, List<Genre> genre)
        {
            _author = author;
            _title = title;
            _genre = new List<Genre>();
        }

        public void AddGenre(Genre genre)
        {
            _genre.Add(genre);
        }

        public void RemoveGenre(Genre genre)
        {
            _genre.Remove(genre);
        }

        public string GetBookTitle()
        {
            return _title;
        }
    }
}