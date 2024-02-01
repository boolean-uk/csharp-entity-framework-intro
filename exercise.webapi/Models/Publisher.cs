namespace exercise.webapi.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class PublisherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthorDto> Books { get; set; } = new();
    }
}
