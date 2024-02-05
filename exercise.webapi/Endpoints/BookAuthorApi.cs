using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class BookAuthorApi
    {
        public static void ConfigureBookAuthorsApi(this WebApplication app)
        {
            app.MapDelete("/bookAuthors/{bookid}/{authorid}", RemoveAuthorFromBook);
            app.MapPost("/bookAuthors/{bookid}/{authorid}", AddAuthorToBook);
        }

        public static async Task<IResult> RemoveAuthorFromBook(int bookId, int authorId, IBookAuthorRepository bookAuthorRepository)
        {
            var result = await bookAuthorRepository.RemoveAuthorFromBookById(bookId, authorId);
            if (result == -1) { return TypedResults.NotFound($"Book {bookId} with author {authorId} doesn't exist."); }
            return TypedResults.Ok();
        }

        public static async Task<IResult> AddAuthorToBook(int bookId, int authorId, IBookAuthorRepository bookAuthorRepository)
        {
            var result = await bookAuthorRepository.AddAuthorToBook(bookId, authorId);
            if (result == -1) { return TypedResults.NotFound($"Book {bookId} doesn't exist."); }
            if (result == -2) { return TypedResults.NotFound($"Author {authorId} doesn't exist."); }
            return TypedResults.Created();
        }
    }
}
