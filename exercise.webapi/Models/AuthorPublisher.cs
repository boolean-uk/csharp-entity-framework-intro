namespace exercise.webapi.Models
{
    public class AuthorPublisher
    {
        public int Id { get; set; }
        public int PublisherId { get; set; }
        public int AuthorId { get; set; }
        public Author author { get; set; }
        public Publisher publisher { get; set; }

    }
}
