namespace exercise.webapi.DTO
{
    public class AuthorPublisherDTO
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public AuthorDTOnoBooks author { get; set; }
        public PublisherDTO publisher { get; set; }
    }
}
