using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints;

public static class BookApi
{
    public static void ConfigureBooksApi(this WebApplication app)
    {
        var group = app.MapGroup("books");

        group.MapGet("/", GetBooks);
        group.MapGet("/{id}", GetBook);
        group.MapPut("/{id}", UpdateBook);
    }

    private static async Task<IResult> GetBooks(IBookRepository bookRepository)
    {
        var books = await bookRepository.GetAllBooks();
        return TypedResults.Ok(books);
    }

    private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
    {
        var book = await bookRepository.GetBookById(id);

        if (book == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(book);
    }

    private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookPush book)
    {
        var updatedBook = await bookRepository.UpdateBook(id, book);

        if (updatedBook == null)
        {
            return TypedResults.BadRequest();
        }

        return TypedResults.Ok(updatedBook);
    }
}
