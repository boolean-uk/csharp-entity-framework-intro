using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookAuthor
    {
        public int Id { get; set; }
        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book book { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }
        public Author author { get; set; }
    }
}
