using exercise.webapi.Models;

namespace exercise.webapi.DTO
{
    public class AuthorWithPublisherAndBookDTO
    {

        public int Id { get; set; }
        public string Title { get; set;}

        public PublisherDTO Publisher { get; set; }

        public AuthorWithPublisherAndBookDTO(Book book) 
        {
            Id = book.Id;
            Title = book.Title;

            Publisher = new PublisherDTO(book.Publisher); 
        }
    }
}
