using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookforAuthorDTO> Books { get; set; } = new List<BookforAuthorDTO>();
    }
}
