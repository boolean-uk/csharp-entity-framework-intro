using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.DTO
{
    public class PublisherResponseDTO
    {

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookAuthorDTO> Books { get; set; } = new List<BookAuthorDTO>();

        public PublisherResponseDTO(Publisher p)
        {
            Id = p.Id;
            Name = p.Name;

            Books = new List<BookAuthorDTO>();
            foreach (var item in p.Books)
            {
                Books.Add(new BookAuthorDTO(item));
            }
        }

        public static List<PublisherResponseDTO> FromRepository(IEnumerable<Publisher> p)
        {
            var res = new List<PublisherResponseDTO>();
            foreach (var item in p)
            {
                res.Add(new PublisherResponseDTO(item));
            }

            return res;
        }
    }
}
