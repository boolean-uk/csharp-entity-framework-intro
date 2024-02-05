using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.JunctionModels;

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

        private List<string> _publishingword = new List<string>()
        {
            "Press",
            "House",
            "Media",
            "Group",
            "Publications",
            "Studios",
            "Group",
            "Media Group",
            "Enterprises"
        };

        private List<string> _publisherstructure = new List<string>()
        {
            "LLC",
            "Corp",
            "Inc",
            "Ltd",
            "GmbH", 
            "Co.", 
            "LP",
            "S.A", 
            "PC"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();
        private List<Publisher> _publishers = new List<Publisher>();
        private List<BookAuthor> _bookAuthors = new List<BookAuthor>();

        public Seeder()
        {

            Random authorRandom = new Random();
            Random bookRandom = new Random();
            Random publisherRandom = new Random();



            for (int x = 1; x < 250; x++)
            {
                Author author = new Author();
                author.AuthorId = x;
                author.FirstName = _firstnames[authorRandom.Next(_firstnames.Count)];
                author.LastName = _lastnames[authorRandom.Next(_lastnames.Count)];
                author.Email = $"{author.FirstName}.{author.LastName}@{_domain[authorRandom.Next(_domain.Count)]}".ToLower();
                _authors.Add(author);
            }

            for (int z = 1; z < 10; z++) 
            {
                Publisher publisher = new Publisher();
                publisher.Id = z;
                publisher.Name = $"" +
                    $"{_secondword[publisherRandom.Next(_secondword.Count)]} " +
                    $"{_publishingword[publisherRandom.Next(_publishingword.Count)]} " +
                    $"{_publisherstructure[publisherRandom.Next(_publisherstructure.Count)]}";
                _publishers.Add(publisher);
            }

            for (int y = 1; y < 250; y++)
            {
                Book book = new Book();
                book.BookId = y;
                book.Title = $"{_firstword[bookRandom.Next(_firstword.Count)]} {_secondword[bookRandom.Next(_secondword.Count)]} {_thirdword[bookRandom.Next(_thirdword.Count)]}";

                Publisher randomPublisher = _publishers[publisherRandom.Next(_publishers.Count)];
                book.PublisherId = randomPublisher.Id;

                _books.Add(book);
            }

            for (int y = 1; y < 250; y++) 
            {
                Book book = _books[y - 1];

                int authorsCount = authorRandom.Next(1, 3); // Add between 1 and 3 authors to each book
                for (int i = 0; i < authorsCount; i++) 
                {
                    Author selectedAuthor = _authors[authorRandom.Next(_authors.Count)];

                    BookAuthor bookAuthor = new BookAuthor() 
                    {
                        BookId = book.BookId,
                        AuthorId = selectedAuthor.AuthorId,
                    };

                    if (!_bookAuthors.Any(ba => (ba.BookId == book.BookId && ba.AuthorId == selectedAuthor.AuthorId))) // Prevent duplicates
                    {
                        _bookAuthors.Add(bookAuthor);
                    }
                    
                }
            }

        }
        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
        public List<Publisher> Publishers { get {  return _publishers; } }
        public List<BookAuthor> Bookauthors { get { return _bookAuthors; } }
    }
}
