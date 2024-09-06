using exercise.webapi.DtoModels.BookApiDtos;
using exercise.webapi.Models;

namespace exercise.webapi.DtoModels.PublisherDtos
{
    public class BookInPublisherDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public BookAuthorDto Author { get; set; }

        public BookInPublisherDto(Book book, BookAuthorDto aDto)
        {
            Id = book.Id;
            Title = book.Title;
            Author = aDto;
        }
    }
}
