namespace exercise.webapi.DTO
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public AuthorResponseDTO Author { get; set; }
        public PublisherResponseDTO Publisher { get; set; }
    }
}