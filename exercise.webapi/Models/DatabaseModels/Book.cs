using exercise.webapi.Models.JunctionModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models.DatabaseModels
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }

        [ForeignKey("Author")]
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

        public IEnumerable<Author> GetAuthors() 
        {
            return BookAuthors.Select(a => a.Author).ToList();
        }

        [ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
