using exercise.webapi.Models.BaseModels;

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
            "Kate",
            "Corky",
            "Ted",
            "Mark",
            "Teddy",
            "Mimmi",
            "Max",
            "Chuck",
            "Chad"
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
            "Middleton",
            "Corky",
            "Zuckerberg",
            "Norris",
            "Kroeger",
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
            "A Bunch of",
            "An Army of",
            "A herd of",
            "My Story:",
            "The Hidden Downsides of",
            "Casually explained:",
            "The Potential of",
            "A Tale of",
            "We Need to Talk About",
            "Keys to",
            "Man's Search for",
            "The Secret of",
            "Untold Stories of",
            "The Story of",
            "The Chronicles of",
            "Story of My Life:"
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
            "Bitter",
            "Ancient",
            "Future",
            "Magnificent",
            "Urban",
            "Cyclical",
            "Award-Winning",
            "Mediocre",
            "Underrated"
        };
        private List<string> _thirdword = new List<string>()
        {
            "Buildings",
            "Cars",
            "Planets",
            "Houses",
            "Flowers",
            "Leopards",
            "Hamsters",
            "Food Trucks",
            "Street Food",
            "Food",
            "Smartphones",
            "Cesspools",
            "Table Cloths",
            "Science Teachers",
            "Vegan Food Recipes",
            "Fake News Stories",
            "Influencers",
            "Craft Beers",
            "Pancakes",
            "Hollywood Actors",
            "Storage Units",
            "Shopping Malls",
            "Politicians",
            "Coffee Cups",
            "Cats",
            "Dogs"
        };

        private List<Author> _authors = new List<Author>();
        private List<Book> _books = new List<Book>();

        public Seeder()
        {

            Random authorRandom = new Random();
            Random bookRandom = new Random();



            for (int x = 1; x < 250; x++)
            {
                Author author = new Author();
                author.ID = x;
                author.FirstName = _firstnames[authorRandom.Next(_firstnames.Count)];
                author.LastName = _lastnames[authorRandom.Next(_lastnames.Count)];
                author.Email = $"{author.FirstName}.{author.LastName}@{_domain[authorRandom.Next(_domain.Count)]}".ToLower();
                _authors.Add(author);
            }


            for (int y = 1; y < 250; y++)
            {
                Book book = new Book();
                book.ID = y;
                book.Title = $"{_firstword[bookRandom.Next(_firstword.Count)]} {_secondword[bookRandom.Next(_secondword.Count)]} {_thirdword[bookRandom.Next(_thirdword.Count)]}";
                book.AuthorID = _authors[authorRandom.Next(_authors.Count)].ID;
                //book.Author = authors[book.AuthorId-1];
                _books.Add(book);
            }


        }
        public List<Author> Authors { get { return _authors; } }
        public List<Book> Books { get { return _books; } }
    }
}
