namespace exercise.webapi.Models
{
    public class BookAuthorDTO
    {
        public string Title { get; set; }
        public int AuthorId { get; set; }

        public int PublisherId { get; set; }

        public PublisherDTO? Publisher { get; set; }

        public AuthorDTO AuthorObj { get; set; }
    }
}
