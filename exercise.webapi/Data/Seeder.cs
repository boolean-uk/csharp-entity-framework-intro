﻿using exercise.webapi.Models;

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

        private List<string> _publisherfirst = new List<string>()
        {
            "The New",
            "Creative",
            "Innovative",
            "Global",
            "Dynamic",
            "Epic",
            "Majestic",
            "Profound",
            "Future",
            "Visionary",
            "Universe",
            "Galactic",
            "Starlight",
            "Evergreen",
            "Alpha",
            "Omega",
            "Frontier",
            "Pioneer",
            "Alpha",
            "Beta"
        };

        private List<string> _publisherlast = new List<string>()
        {
            "Company",
            "Press",
            "Publications",
            "Books",
            "Media",
            "Ink",
            "Verse",
            "Imprint",
            "Literature",
            "Chronicle",
            "Editions",
            "Words",
            "Harbor",
            "Echo",
            "Ventures",
            "Explorations",
            "Voyages",
            "Scribe",
            "Quill"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();
        private List<Publisher> _publishers = new List<Publisher>();

        public Seeder()
        {

            Random authorRandom = new Random();
            Random bookRandom = new Random();



            for (int x = 1; x < 50; x++)
            {
                Author author = new Author();
                author.Id = x;
                author.FirstName = _firstnames[authorRandom.Next(_firstnames.Count)];
                author.LastName = _lastnames[authorRandom.Next(_lastnames.Count)];
                author.Email = $"{author.FirstName}.{author.LastName}@{_domain[authorRandom.Next(_domain.Count)]}".ToLower();
                _authors.Add(author);
            }

            for (int x = 1; x < 50; x++)
            {
                Publisher publisher = new Publisher();
                publisher.Id = x;
                string NameA = _publisherfirst[authorRandom.Next(_publisherfirst.Count)];
                string NameB = _publisherlast[authorRandom.Next(_publisherlast.Count)];
                publisher.Name = NameA + " " + NameB;
                _publishers.Add(publisher);
            }

            for (int y = 1; y < 50; y++)
            {
                Book book = new Book();
                book.Id = y;
                book.Title = $"{_firstword[bookRandom.Next(_firstword.Count)]} {_secondword[bookRandom.Next(_secondword.Count)]} {_thirdword[bookRandom.Next(_thirdword.Count)]}";
                book.AuthorId = _authors[authorRandom.Next(_authors.Count)].Id;
                book.PublisherId = _publishers[authorRandom.Next(_publishers.Count)].Id;
                //book.Author = _authors[book.AuthorId-1];
                _books.Add(book);
            }


        }
        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
        public List<Publisher> Publishers { get { return _publishers; } }
    }
}
