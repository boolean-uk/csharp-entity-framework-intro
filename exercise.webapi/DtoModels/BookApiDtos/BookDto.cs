using exercise.webapi.Models;

namespace exercise.webapi.DtoModels.BookApiDtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public BookAuthorDto Author { get; set; }

        public PublisherInBookDto Publisher { get; set; }

        public BookDto(Book book, BookAuthorDto aDto, string publisherName)
        {
            Id = book.Id;
            Title = book.Title;
            Author = aDto;
            Publisher = new PublisherInBookDto(publisherName);
        }
    }
}
