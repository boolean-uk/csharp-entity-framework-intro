using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace exercise.webapi.Models
{
    public class BookAuthor
    {
        
        [Key]
        public int Id { get; set; }

        
        public int BookId { get; set; }
        [ForeignKey("BookId")]
        public Book Book { get; set; }

        public int AuthorId { get; set; }
        [ForeignKey("AuthorId")]
        public Author Author { get; set; }
        
    }
}
