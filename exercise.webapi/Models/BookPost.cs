using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookPost
    {
        public string Title { get; set; }
        
        public int AuthorId { get; set; }
    }
}
