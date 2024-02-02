using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<BookResponseDTO> PublishedBooks { get; set; } = new List<BookResponseDTO>();
    }
}
