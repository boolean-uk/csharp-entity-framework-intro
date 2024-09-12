using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class GetBookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author AuthorDto { get; set; }
    }
}
