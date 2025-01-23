using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapGet("/books/delete/{id}", DeleteBook);
            app.MapPost("/books/update", UpdateBook);
            app.MapPost("/books/add", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books.Select(b => new BookDTO(b)));
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return TypedResults.NotFound("No book with give id");
            }
            return TypedResults.Ok(new BookDTO(book));
        }

        private static async Task<IResult> CreateBook(
            IBookRepository bookRepository,
            BookPostDTO book
        )
        {
            try
            {
                var result = await bookRepository.CreateBook(
                    new Book
                    {
                        AuthorId = book.AuthorId,
                        Title = book.Title,
                        PublisherId = book.PublisherId,
                    }
                );
                if (result == null)
                {
                    return TypedResults.NotFound("Author or publisher not found");
                }
                return TypedResults.Ok(new BookDTO(result));
            }
            catch (Exception e)
            {
                return TypedResults.BadRequest(e);
            }
        }

        private static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            var deleted = await repository.DeleteBook(id);
            if (!deleted)
            {
                return TypedResults.NotFound("No book with given id");
            }
            return TypedResults.Ok();
        }

        private static async Task<IResult> UpdateBook(
            IBookRepository repo,
            int bookId,
            int authorId
        )
        {
            var result = await repo.UpdateAuthor(bookId, authorId);
            if (result == null)
            {
                return TypedResults.NotFound("Book or author with given id does not exist");
            }
            return TypedResults.Ok(new BookDTO(result));
        }
    }
}
