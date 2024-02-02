using System.Reflection.Metadata.Ecma335;

namespace exercise.webapi.Models
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<BookAuthorDTO> PublishedBooks { get; set; } = new List<BookAuthorDTO>();
    }
}
