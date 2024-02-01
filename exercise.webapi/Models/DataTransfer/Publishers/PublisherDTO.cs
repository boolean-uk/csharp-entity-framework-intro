using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer.Books;

namespace exercise.webapi.Models.DataTransfer.Publishers
{
    public class PublisherDTO(int Id, string Name)
    {
        public int Id { get; set; } = Id;
        public string Name { get; set; } = Name;

        public IEnumerable<BookInPublisherDTO> Books { get; set; }
    }
}
