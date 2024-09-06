using exercise.webapi.Models;
using System.Text.Json.Serialization;

namespace exercise.webapi.DtoModels.AuthorApiDtos
{
    public class BookInAuthorDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string PublisherName { get; set; }
        public BookInAuthorDto(Book book, string publisherName)
        {
            Id = book.Id;
            Title = book.Title;
            PublisherName = publisherName;
        }
    }
}
