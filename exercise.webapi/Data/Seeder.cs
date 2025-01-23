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
        private List<string> _publisherStrings = new List<string>()
        {
            "Penguin",
            "Random House",
            "Harper Collins",
            "Simon & Schuster",
            "Macmillan",
            "Hachette",
            "Pearson",
            "Scholastic",
            "Bloomsbury",
            "Oxford University Press"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();
        private List<Publisher> _publishers = new List<Publisher>();
        private List<BookAuthor> _bookAuthors = new List<BookAuthor>();
        private List<Checkout> _checkouts = new List<Checkout>();


        public Seeder()
        {

            Random authorRandom = new Random();
            Random bookRandom = new Random();
            Random publisherRand = new Random();
            //Random bookAuthorRandom = new Random();



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
                Book book = new Book();
                book.Id = y;
                book.Title = $"{_firstword[bookRandom.Next(_firstword.Count)]} {_secondword[bookRandom.Next(_secondword.Count)]} {_thirdword[bookRandom.Next(_thirdword.Count)]}";
                //book.Authors = new List<Author> { _authors[authorRandom.Next(_authors.Count)] };
                book.PublisherId = publisherRand.Next(1, 11);
                _books.Add(book);
            }

            for(int z = 1; z < 11; z++)
            {
                Publisher publisher = new Publisher();
                publisher.Id = z;
                publisher.Name = _publisherStrings[z - 1];
                _publishers.Add(publisher);
            }

            //Randomly assign authors to books, they should have at least one author, but can have more
            foreach (var book in _books)
            {
                int numberOfAuthors = authorRandom.Next(1, 4);
                for (int i = 0; i < numberOfAuthors; i++)
                {
                    BookAuthor bookAuthor = new BookAuthor();
                    bookAuthor.Id = _bookAuthors.Count + 1;
                    bookAuthor.AuthorId = authorRandom.Next(1, 250);
                    bookAuthor.BookId = book.Id;
                    _bookAuthors.Add(bookAuthor);
                }
            }


            //Randomly check some books out. They should all be from various previous dates, some should be overdue, but not most.
            Random checkoutRandom = new Random();
            for (int i = 1; i < 100; i++)
            {
                Checkout checkout = new Checkout();
                checkout.Id = i;
                checkout.BookId = bookRandom.Next(1, 250);
                checkout.CheckoutDate = DateTime.Now.AddDays(-checkoutRandom.Next(1, 365));
                checkout.DueDate = checkout.CheckoutDate.AddDays(14);
                checkout.IsReturned = checkoutRandom.Next(0, 2) == 1 ? true : false;
                _checkouts.Add(checkout);
            }


        }
        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
        public List<Publisher> Publishers { get { return _publishers; } }
        public List<BookAuthor> BookAuthors { get { return _bookAuthors; } }
        public List<Checkout> Checkouts { get { return _checkouts; } }
    }
}
