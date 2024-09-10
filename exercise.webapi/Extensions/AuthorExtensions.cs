using exercise.webapi.DTOs;
using exercise.webapi.Models;

namespace exercise.webapi.Extensions
{
    public static class AuthorExtensions
    {
        public static AuthorDTO MapToAuthorDTO(this Author author)
        {
            List<BookPublisherDTO> books = (from book in author.Books select book.MapToBookPublisherDTO()).ToList();
            return new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = books
            };
        }
    }
}
