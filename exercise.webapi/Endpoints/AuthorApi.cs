using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("/authors");
            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IRepository bookRepository)
        {
            var books = await bookRepository.GetAllAuthors();
            return TypedResults.Ok(books);
        }
        private static async Task<IResult> GetAuthor(IRepository bookRepository, int id)
        {
            var book = await bookRepository.GetAuthorById(id);
            return TypedResults.Ok(book);
        }
        
    }
}
