namespace exercise.webapi.Models
{
    public class BookDto
    {
        public string Title { get; set; }
        public AuthorDto Author { get; set; }

        public PublisherDto Publisher { get; set; }
    }
}
