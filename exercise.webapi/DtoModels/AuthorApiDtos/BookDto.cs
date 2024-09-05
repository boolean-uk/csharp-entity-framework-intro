using exercise.webapi.DtoModels.BookApiDtos;
using exercise.webapi.Models;

namespace exercise.webapi.DtoModels.AuthorApiDtos
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public BookAuthorDto Author { get; set; }

        public BookDto(Book book, BookAuthorDto aDto)
        {
            Id = book.Id;
            Title = book.Title;
            Author = aDto;
        }
    }
}
