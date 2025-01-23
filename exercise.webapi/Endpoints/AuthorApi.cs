using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();

            var authorDTOs = authors.Select(author => new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(book => new MinimalBookDTO
                {
                    Id = book.Id,
                    Title = book.Title
                }).ToList()
            }).ToList();

            return TypedResults.Ok(authorDTOs);
        }
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            var authorDTOs = new AuthorDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books.Select(book => new MinimalBookDTO
                {
                    Id = book.Id,
                    Title = book.Title
                }).ToList()
            };
            return TypedResults.Ok(authorDTOs);
        }
    }
}
