using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherResponseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookWithAuthorDTO> Books { get; set; } = new List<BookWithAuthorDTO>();
        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();

        public PublisherResponseDTO(Publisher publisher)
        {
            Id = publisher.Id; // no not want this time
            Name = publisher.Name;

            Books = new List<BookWithAuthorDTO>();
        
            foreach (var book in publisher.Books) { 
                Books.Add(new BookWithAuthorDTO(book));
                
            }
            Authors = new List<AuthorDTO>();
            

        }

        public static List<PublisherResponseDTO> FromRepository(IEnumerable<Publisher> publishers)
        {
            var result = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
            {
                result.Add(new PublisherResponseDTO(publisher));
            }

            return result;
        }

    }
}
