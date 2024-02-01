namespace exercise.webapi.Models
{
    public class PublisherDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BookDTO> Books { get; set; }
    }
}
