namespace exercise.webapi.DTOs
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int PublisherId { get; set; }
        public PublisherDTO Publisher { get; set; }
        public ICollection<AuthorDTO> Authors { get; set; } = new List<AuthorDTO>();
    }
}
