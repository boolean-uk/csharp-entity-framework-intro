using System.ComponentModel.DataAnnotations.Schema;
using exercise.webapi.DTO;

namespace exercise.webapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
       
        
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
        public Author Author { get; set; }
        public Publisher Publisher { get; set; }
        public AuthorPublisher? AuthorPublisher { get; set; }
    }
}
