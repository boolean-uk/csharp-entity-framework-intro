using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<BookAuthorDTO> Books { get; set; } = new List<BookAuthorDTO>();

        public PublisherDTO(Publisher p) 
        {
            Id = p.Id;
            Name = p.Name;

            Books = new List<BookAuthorDTO>();
            foreach (var item in p.Books)
            {
                Books.Add(new BookAuthorDTO(item));
            }
        }
    }
}
