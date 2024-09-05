using exercise.webapi.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.DTO
{
    public class PublisherResponseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public ICollection<AuthorDTO> Author { get; set; } = new List<AuthorDTO>();

        public PublisherResponseDTO(Publisher publisher)
        {
            Id = publisher.Id;
            Name = publisher.Name;
            Location = publisher.Location;
            Author = new List<AuthorDTO>();

            foreach (var author in publisher.Authors)
            {
                Author.Add(new AuthorDTO(author));
            }

  

        }

        public static List<PublisherResponseDTO> FromRepository(IEnumerable<Publisher> publishers)
        {
            var results = new List<PublisherResponseDTO>();
            foreach (var publisher in publishers)
            {
                results.Add(new PublisherResponseDTO(publisher));
            }
            return results;
        }
    }
}
