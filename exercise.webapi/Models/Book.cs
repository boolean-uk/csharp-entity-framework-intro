using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        
        [ForeignKey("AuthorId")]
        public int AuthorId { get; set; }
        public Author Author { get; set; }

        [ForeignKey("PublisherId")]
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }
    }
}
