using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookPost
    {
        public string Title { get; set; }
        public int PublisherId { get; set; }
        public List<int> AuthorIds { get; set; }
    }
}
