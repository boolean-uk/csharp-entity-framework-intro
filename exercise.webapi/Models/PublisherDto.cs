namespace exercise.webapi.Models
{
    public class PublisherDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<BookAuthorDto> Books { get; set; }
    }
}
