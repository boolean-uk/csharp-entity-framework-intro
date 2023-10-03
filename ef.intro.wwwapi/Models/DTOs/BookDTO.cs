namespace ef.intro.wwwapi.Models.DTOs
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; } //instead of the entire author object
        public int PublisherId { get; set; }
        public string PublisherName { get; set; } // instead of the entire publisher object
    }
}
