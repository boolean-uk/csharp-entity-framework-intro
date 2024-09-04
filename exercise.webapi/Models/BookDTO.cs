namespace exercise.webapi.Models
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int authorId { get; set; }
        public string AuthorName { get; set; }

        public int PublisherId { get; set; }
        public string PublisherName { get; set; }

    }
}
