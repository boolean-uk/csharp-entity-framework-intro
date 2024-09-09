using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class BookPublisherDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public int AuthorId { get; set; }
        public AuthorWithoutEmailBooks Author { get; set; }  

        public int PublisherId { get; set; }
        public PublisherWithoutBooksDTO Publisher { get; set; }
    }
}
