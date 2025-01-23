using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; } = string.Empty;
        public string PublisherName { get; set; } = string.Empty;
    }

    public class BookAuthorDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; } = string.Empty;
    }

    public class BookPublisherDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string PublisherName { get; set; } = string.Empty;
    }
}
