using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookPostDTO
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int PublisherId { get; set; }
    }
}
