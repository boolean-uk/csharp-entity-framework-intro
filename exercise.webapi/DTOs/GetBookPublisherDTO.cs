using exercise.webapi.Models;

namespace exercise.webapi.DTOs
{
    public class GetBookPublisherDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Author Author { get; set; }
    }
}
