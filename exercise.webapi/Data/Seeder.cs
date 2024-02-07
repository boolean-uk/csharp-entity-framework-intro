using exercise.webapi.Models;

namespace exercise.webapi.Data
{
    public class Seeder
    {
        private List<string> _firstnames = new List<string>()
        {
            "Audrey",
            "Donald",
            "Elvis",
            "Barack",
            "Oprah",
            "Jimi",
            "Mick",
            "Kate",
            "Charles",
            "Kate"
        };
        private List<string> _lastnames = new List<string>()
        {
            "Hepburn",
            "Trump",
            "Presley",
            "Obama",
            "Winfrey",
            "Hendrix",
            "Jagger",
            "Winslet",
            "Windsor",
            "Middleton"

        };
        private List<string> _domain = new List<string>()
        {
            "bbc.co.uk",
            "google.com",
            "theworld.ca",
            "something.com",
            "tesla.com",
            "nasa.org.us",
            "gov.us",
            "gov.gr",
            "gov.nl",
            "gov.ru"
        };
        private List<string> _firstword = new List<string>()
        {
            "The",
            "Two",
            "Several",
            "Fifteen",
            "A bunch of",
            "An army of",
            "A herd of"


        };
        private List<string> _secondword = new List<string>()
        {
            "Orange",
            "Purple",
            "Large",
            "Microscopic",
            "Green",
            "Transparent",
            "Rose Smelling",
            "Bitter"
        };
        private List<string> _thirdword = new List<string>()
        {
            "Buildings",
            "Cars",
            "Planets",
            "Houses",
            "Flowers",
            "Leopards"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();
        private List<BookAuthor> _bookAuthorPairs = new List<BookAuthor>();

        public Seeder()
        {
            Random random = new Random();
            for (int x = 1; x <= 250; x++)
            {
                Author author = new Author
                {
                    Id = x,
                    FirstName = _firstnames[random.Next(_firstnames.Count)],
                    LastName = _lastnames[random.Next(_lastnames.Count)],
                    Email = $"{_firstnames[random.Next(_firstnames.Count)]}.{_lastnames[random.Next(_lastnames.Count)]}@{_domain[random.Next(_domain.Count)]}".ToLower()
                };
                _authors.Add(author);
            }

            for (int y = 1; y <= 250; y++)
            {
                Book book = new Book
                {
                    Id = y,
                    Title = $"{_firstword[random.Next(_firstword.Count)]} {_secondword[random.Next(_secondword.Count)]} {_thirdword[random.Next(_thirdword.Count)]}"
                };
                _books.Add(book);
            }

            foreach (var book in _books)
            {
                int numberOfAuthorsForThisBook = random.Next(1, 4);
                for (int i = 0; i < numberOfAuthorsForThisBook; i++)
                {
                    var author = _authors[random.Next(_authors.Count)];
                    var pair = new BookAuthor { BookId = book.Id, AuthorId = author.Id };

                    if (!_bookAuthorPairs.Any(ba => ba.BookId == pair.BookId && ba.AuthorId == pair.AuthorId))
                    {
                        _bookAuthorPairs.Add(pair);
                    }
                }
            }
        }

        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
        public List<BookAuthor> BookAuthorPairs { get { return _bookAuthorPairs; } }
    }
}
