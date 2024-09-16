using exercise.webapi.Models.DTO;

namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; } = new List<Book>();

        public PublisherDTO ToDTO()
        {
            return new PublisherDTO { Id = Id, Name = Name };
        }

        public PublisherResponseDTO ToDTO(List<BookAuthorResponseDTO> bookDTO)
        {
            return new PublisherResponseDTO { Id = Id, Name = Name, Books = bookDTO };
        }
    }
}
