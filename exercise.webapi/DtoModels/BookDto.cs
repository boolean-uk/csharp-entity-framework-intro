using exercise.webapi.DtoModels;
using exercise.webapi.Models;

namespace exercise.webapi.DTOModels
{
    public class BookDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public AuthorDto Author { get; set; }

        public BookDto(Book book, AuthorDto aDto)
        {
            Id = book.Id;
            Title = book.Title;
            Author = aDto;
        }
    }
}
