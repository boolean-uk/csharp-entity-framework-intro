using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

    }
}
