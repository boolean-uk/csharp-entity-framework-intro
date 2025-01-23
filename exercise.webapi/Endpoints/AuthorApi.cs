using exercise.webapi.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("/authors");

            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetSingleAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();

            // Handle null or empty list
            if (authors == null || !authors.Any())
            {
                return Results.Ok(new List<AuthorReponseDTO>());
            }

            var authorResponses = authors.Select(author => new AuthorReponseDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books?.Select(book => new BookResponseDTO
                {
                    Title = book.Title
                }).ToList() ?? new List<BookResponseDTO>()
            }).ToList();

            return Results.Ok(authorResponses);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetSingleAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthorById(id);
            if (author == null)
            {
                return Results.NotFound();
            }
            var authorResponse = new AuthorReponseDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(book => new BookResponseDTO
                {
                    Title = book.Title
                }).ToList()
            };
            return Results.Ok(authorResponse);
        }
    }
}
