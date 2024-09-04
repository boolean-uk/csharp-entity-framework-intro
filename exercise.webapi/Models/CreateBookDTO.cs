using System.ComponentModel.DataAnnotations;

namespace exercise.webapi.Models
{
    public class CreateBookDTO
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
    }
}
