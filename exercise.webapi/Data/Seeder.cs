using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Data
{
    public class Seeder
    {
        private List<string> _firstnames = new List<string>()
        {
            "Audrey", "Donald", "Elvis", "Barack", "Oprah",
            "Jimi", "Mick", "Kate", "Charles", "Kate"
        };

        private List<string> _lastnames = new List<string>()
        {
            "Hepburn", "Trump", "Presley", "Obama", "Winfrey",
            "Hendrix", "Jagger", "Winslet", "Windsor", "Middleton"
        };

        private List<string> _domain = new List<string>()
        {
            "bbc.co.uk", "google.com", "theworld.ca", "something.com",
            "tesla.com", "nasa.org.us", "gov.us", "gov.gr", "gov.nl", "gov.ru"
        };

        private List<string> _firstword = new List<string>()
        {
            "The", "Two", "Several", "Fifteen", "A bunch of", "An army of", "A herd of"
        };

        private List<string> _secondword = new List<string>()
        {
            "Orange", "Purple", "Large", "Microscopic", "Green", "Transparent", "Rose Smelling", "Bitter"
        };

        private List<string> _thirdword = new List<string>()
        {
            "Buildings", "Cars", "Planets", "Houses", "Flowers", "Leopards"
        };

        private List<string> _publisherNames = new List<string>()
        {
            "Penguin Random House", "Simon & Schuster", "HarperCollins",
            "Hachette Livre", "Scholastic", "Macmillan Publishers",
            "Bloomsbury Publishing", "DK Publishing", "Wiley", "McGraw-Hill Education"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();
        private List<Publisher> _publishers = new List<Publisher>();

        public Seeder()
        {
            Random random = new Random();

            // Create Authors
            for (int x = 1; x <= 50; x++)
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

            // Create Publishers
            for (int x = 1; x <= _publisherNames.Count; x++)
            {
                Publisher publisher = new Publisher
                {
                    Id = x,
                    Name = _publisherNames[x - 1]
                };
                _publishers.Add(publisher);
            }

            // Create Books
            for (int x = 1; x <= 50; x++)
            {
                Author randomAuthor = _authors[random.Next(_authors.Count)];
                Publisher randomPublisher = _publishers[random.Next(_publishers.Count)];

                Book book = new Book
                {
                    Id = x,
                    Title = $"{_firstword[random.Next(_firstword.Count)]} {_secondword[random.Next(_secondword.Count)]} {_thirdword[random.Next(_thirdword.Count)]}",
                    AuthorId = randomAuthor.Id,
                    PublisherId = randomPublisher.Id
                };

                _books.Add(book);
            }

        }
        public List<Author> Authors => _authors;
        public List<Book> Books => _books;
        public List<Publisher> Publishers => _publishers;
    }
    
}
