using exercise.webapi.Models;

namespace exercise.webapi.DTO_s
{
    public class PublisherDto
    {
        public int Id { get; internal set; }
        public string Name { get; set; }

        public ICollection<BookDTO> Books { get; set; } = new List<BookDTO>();
    }
}
