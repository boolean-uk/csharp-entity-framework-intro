using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }

        public string Author { get; set; }

        public int PublisherId { get; set; }

        public string Publisher { get; set; }

    }
}
