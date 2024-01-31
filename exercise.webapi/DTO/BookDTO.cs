using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [ForeignKey("Author")]
        public int AuthorId { get; set; }

        public AuthorDTO Author { get; set; }
    }
}
