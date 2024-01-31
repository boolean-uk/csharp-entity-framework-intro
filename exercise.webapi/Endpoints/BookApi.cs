using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints;

public static class BookApi
{
    public static void ConfigureBooksApi(this WebApplication app)
    {
        var group = app.MapGroup("books");

        group.MapGet("/", GetBooks);
        group.MapGet("/{id}", GetBook);
        group.MapPut("/{id}", UpdateBook);
        group.MapDelete("/{id}", DeleteBook);
        group.MapPost("/", CreateBook);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetBooks(IBookRepository bookRepository)
    {
        var books = await bookRepository.GetAllBooks();
        return TypedResults.Ok(books);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
    {
        var book = await bookRepository.GetBookById(id);

        if (book == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(book);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookPost book)
    {
        var updatedBook = await bookRepository.UpdateBook(id, book);

        if (updatedBook == null)
        {
            return TypedResults.BadRequest();
        }

        return TypedResults.Ok(updatedBook);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
    {
        var deletedBook = await bookRepository.DeleteBook(id);

        if (deletedBook == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(deletedBook);
    }
    [ProducesResponseType(StatusCodes.Status201Created)]
    private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPost book)
    {
        if (string.IsNullOrEmpty(book.Title))
        {
            return TypedResults.BadRequest($"Title can not be empty!");
        }

        var createdBook = await bookRepository.CreateBook(book);

        if (createdBook == null)
        {
            return TypedResults.NotFound($"Author-Id: {book.AuthorId} not found!");
        }

        int newId = await bookRepository.GetNewId();

        return TypedResults.Created($"/{newId}", createdBook);
    }
}
