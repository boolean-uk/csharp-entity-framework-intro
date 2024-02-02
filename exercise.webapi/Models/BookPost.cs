using exercise.webapi.Models.DatabaseModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    public class BookPost
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
