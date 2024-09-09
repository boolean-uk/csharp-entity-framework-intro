using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookWithoutAuthor
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public PublisherWithoutBooksDTO Publisher { get; set; }

    }
}
