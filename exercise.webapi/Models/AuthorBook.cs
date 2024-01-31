using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class AuthorBook
    {
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public Author Author { get; set; } // = null!;

        [ForeignKey("BookId")] // Adjusted to match the primary key of the Book entity
        public int BookId { get; set; }
        public Book Book { get; set; } // = null!;
    }
}
