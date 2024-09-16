namespace exercise.webapi.Models.DTO
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public PublisherDTO Publisher { get; set; }
    }
}
