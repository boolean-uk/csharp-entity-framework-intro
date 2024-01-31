using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class CreateBookDTO
    {
        public string? Title { get; set; } = null;
        public int? AuthorId { get; set; } = null;
    }
}
