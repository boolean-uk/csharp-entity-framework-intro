using exercise.webapi.Models.DatabaseModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookPost
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        
        public int PublisherId { get; set; }
    }
}
