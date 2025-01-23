using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var author = app.MapGroup("author");

            author.MapGet("/", GetAllAuthors);
            author.MapGet("/{id}", GetAuthorById);
        }

        public static async Task<IResult> GetAllAuthors(IRepository<Author> authorRepository)
        {
            BookPaylaod<IEnumerable<Author>> payload = new();

            var authors = await authorRepository.GetAllEntities();

            payload.Data = authors.ToList();

            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> GetAuthorById(IRepository<Book> authorRepository, int id)
        {
            BookPaylaod<Book> payload = new()
            {
                Data = await authorRepository.GetEntityById(id),
            };

            payload.Message = (payload.Data is null) ? "No book matching provided ID" : "OK";

            return TypedResults.Ok(payload);
        }
    }
}
