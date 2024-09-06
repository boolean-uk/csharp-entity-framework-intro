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
        public List<BookAuthor> BookAuthors { get; private set; } = new List<BookAuthor>();

        public Seeder()
        {

            Random authorRandom = new Random();
            Random bookRandom = new Random();



            for (int x = 1; x < 250; x++)
            {
                Author author = new Author();
                author.Id = x;
                author.FirstName = _firstnames[authorRandom.Next(_firstnames.Count)];
                author.LastName = _lastnames[authorRandom.Next(_lastnames.Count)];
                author.Email = $"{author.FirstName}.{author.LastName}@{_domain[authorRandom.Next(_domain.Count)]}".ToLower();
                _authors.Add(author);
            }


            for (int y = 1; y < 250; y++)
            {
                Book book = new Book
                {
                    Id = y,
                    Title = $"{_firstword[bookRandom.Next(_firstword.Count)]} {_secondword[bookRandom.Next(_secondword.Count)]} {_thirdword[bookRandom.Next(_thirdword.Count)]}"
                };

                var selectedAuthors = Authors.OrderBy(a => Guid.NewGuid()).Take(3).ToList(); // Select 3 random authors

                foreach (var author in selectedAuthors)
                {
                    BookAuthors.Add(new BookAuthor
                    {
                        BookId = book.Id,
                        AuthorId = author.Id
                    });
                }

                Books.Add(book);
            }


        }
        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
    }
}
