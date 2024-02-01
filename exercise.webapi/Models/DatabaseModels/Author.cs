using exercise.webapi.Models.JunctionModels;
using System.Text.Json.Serialization;

namespace exercise.webapi.Models.DatabaseModels
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

        public IEnumerable<Book> GetBooks() 
        {
            return BookAuthors.Select(b => b.Book).ToList();
        }

    }
}
