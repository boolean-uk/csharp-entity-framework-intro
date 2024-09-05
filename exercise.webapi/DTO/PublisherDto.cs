namespace exercise.webapi.DTO
{
    public class PublisherDto
    {
        public int Id { get; set; }
        public string PublisherName { get; set; }
        public IEnumerable<BookDto> Books { get; set; }
    }
}
