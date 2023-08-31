namespace Library
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Library library = new Library(bookWrapper: null);

            Genre horror = new Genre("Horror");
            Genre comedy = new Genre("Comedy");
            Genre adventure = new Genre("Adventure");
            Genre epopee = new Genre("épopée");

            Author author1 = new Author("Dante", "", books: null);

            Book divine = new Book(author1, "Divine Comédie", genre: null);

            divine.AddGenre(epopee);

            author1.AddBook(divine);

            BookWrapper bookWrapper = new BookWrapper(divine, "978-975-329-681-6", 7, 7, "A-1 ");

            library.AddBook(bookWrapper);

            Borrower borrower = new Borrower("Sam-et", "asd@mail.com", "12345");

            if (!borrower.LogIn())
            {
                return;
            }
        }
    }
}