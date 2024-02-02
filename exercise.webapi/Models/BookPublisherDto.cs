namespace exercise.webapi.Models
{
    public class BookPublisherDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public PublisherPlainDto Publisher { get; set; }
    }
}
