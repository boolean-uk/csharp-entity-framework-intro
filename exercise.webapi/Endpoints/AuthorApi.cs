using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthor(IBookRepository repository, int id)
        {
            BookDTO book = await repository.GetBook(id);
            return TypedResults.Ok(book);
        }

        private static async Task<IResult> GetAuthors(IBookRepository repository)
        {
            var books = await repository.GetAllBooks();
            return TypedResults.Ok(books);
        }
    }
}
