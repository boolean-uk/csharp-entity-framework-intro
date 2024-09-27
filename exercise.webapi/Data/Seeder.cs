using exercise.webapi.Models.Types;

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

        private List<string> _publisherNamesStart = new List<string>()
        {
            "Black",
            "Hachette",
            "Macmillan",
            "Harper",
            "Penguin",
            "Merriam"
        };

        private List<string> _publisherNamesEnd = new List<string>()
        {
            "Library",
            "Book Group",
            "Publishers",
            "Collins",
            "Random House",
            "Webster"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();
        private List<Publisher> _publishers = new List<Publisher>();
        private List<AuthorBook> _authorBooks = new List<AuthorBook>();

        public Seeder()
        {

            Random authorRandom = new Random();
            Random bookRandom = new Random();
            Random publisherRandom = new Random();

            for (int x = 1; x < 10; x++)
            {
                Author author = new Author();
                author.Id = x;
                author.FirstName = _firstnames[authorRandom.Next(_firstnames.Count)];
                author.LastName = _lastnames[authorRandom.Next(_lastnames.Count)];
                author.Email = $"{author.FirstName}.{author.LastName}@{_domain[authorRandom.Next(_domain.Count)]}".ToLower();
                _authors.Add(author);
            }

            for (int y = 1; y < 5; y++)
            {
                Publisher publisher = new Publisher();
                publisher.Id = y;
                publisher.Name = $"{_publisherNamesStart[publisherRandom.Next(_publisherNamesStart.Count)]} {_publisherNamesEnd[publisherRandom.Next(_publisherNamesEnd.Count)]}";
                _publishers.Add(publisher);
            }

            for (int y = 1; y < 25; y++)
            {
                Book book = new Book();
                book.Id = y;
                book.Title = $"{_firstword[bookRandom.Next(_firstword.Count)]} {_secondword[bookRandom.Next(_secondword.Count)]} {_thirdword[bookRandom.Next(_thirdword.Count)]}";
                book.PublisherId = _publishers[authorRandom.Next(_publishers.Count)].Id;
                //book.Author = authors[book.AuthorId-1];
                _books.Add(book);
            }


            AuthorBook authorBook = new AuthorBook()
            {
                AuthorId = 1,
                BookId = 1
            };
            _authorBooks.Add(authorBook);
            /*for (int y = 1; y < 30; y++)
            {
                AuthorBook authorBook = new AuthorBook();
                authorBook.AuthorId = _authors[authorRandom.Next(_authors.Count)].Id;
                authorBook.BookId = _books[bookRandom.Next(_books.Count)].Id;
                _authorBooks.Add(authorBook);
            }*/
        }
        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
        public List<Publisher> Publishers { get { return _publishers; } }
        public List<AuthorBook> AuthorBooks { get { return _authorBooks; } }
    }
}
