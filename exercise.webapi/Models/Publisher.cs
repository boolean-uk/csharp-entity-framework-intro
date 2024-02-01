using System.ComponentModel.DataAnnotations.Schema;

namespace exercise.webapi.Models
{
    [Table("publishers")]
    public class Publisher
    {
        [Column("publisher_id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("books")]
        public List<Book> Books { get; set; } = new List<Book>();
    }

    public class PublisherDto
    {
        public string Name { get; set; }
        public List<BookInPublisherDto> Books { get; set; } = new List<BookInPublisherDto>();
        public PublisherDto(Publisher publisher)
        {
            Name = publisher.Name;
        }
    }

    public class PublisherInBookDto
    {
        public string Name { get; set; }
        public PublisherInBookDto(Publisher publisher)
        {
            Name = publisher.Name;
        }
    }
}
