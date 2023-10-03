using System.ComponentModel.DataAnnotations.Schema;

namespace ef.intro.wwwapi.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [ForeignKey("Author")]
        public int AuthorId { get; set; }
    }
}