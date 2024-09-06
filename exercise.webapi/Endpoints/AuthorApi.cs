using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAllAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        public static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository) 
        {
            var authors = await authorRepository.GetAll();
            List<AuthorDTO> authorsDTO = (from author in authors select MapToAuthorDTO(author)).ToList();
            return TypedResults.Ok(authorsDTO);
        }
        public static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id) 
        {
            var author = await authorRepository.GetAuthor(id);
            return TypedResults.Ok(MapToAuthorDTO(author));
        }

        private static BookDTO MapToBookDTO(Book book)
        {
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = $"{book.Author.FirstName} {book.Author.LastName}"
            };
        }

        private static AuthorDTO MapToAuthorDTO(Author author)
        {
            List<BookDTO> books = (from book in author.Books select MapToBookDTO(book)).ToList();
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
