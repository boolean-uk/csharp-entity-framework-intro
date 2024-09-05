using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public ICollection<BookAuthor> BookAuthorPairs { get; set; } = new List<BookAuthor>();
    }
}
