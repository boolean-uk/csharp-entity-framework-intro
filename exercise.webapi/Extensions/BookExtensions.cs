using exercise.webapi.DTOs;
using exercise.webapi.Models;

namespace exercise.webapi.Extensions
{
    public static class BookExtensions
    {
        public static BookDTO MapToBookDTO(this Book book)
        {
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = $"{book.Author.FirstName} {book.Author.LastName}",
                Publisher = book.Publisher.Name,
                PublisherId = book.PublisherId,
            };
        }

        public static BookAuthorDTO MapToBookAuthorDTO(this Book book)
        {
            return new BookAuthorDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = $"{book.Author.FirstName} {book.Author.LastName}"
            };
        }

        public static BookPublisherDTO MapToBookPublisherDTO(this Book book)
        {
            return new BookPublisherDTO
            {
                Id = book.Id,
                Title = book.Title,
                PublisherId = book.PublisherId,
                Publisher = book.Publisher.Name

            };
        }
    }
}
