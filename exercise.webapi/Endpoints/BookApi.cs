using exercise.webapi.Models.DTOs;
using exercise.webapi.Models.InputTypes;
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
        group.MapPut("/addAuthor/{id}", AddAuthorToBook);
        group.MapPut("/removeAuthor/{id}", RemoveAuthorFromBook);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetBooks(IBookRepository bookRepository)
    {
        var books = await bookRepository.GetAllBooks();
        var returnList = new List<BookWithAuthorAndPublisherDTO>();
        foreach (var book in books)
        {
            returnList.Add(BookWithAuthorAndPublisherDTO.bookToDTO(book));
        }

        return TypedResults.Ok(returnList);
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
    {
        var book = await bookRepository.GetBookById(id);

        if (book == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(BookWithAuthorAndPublisherDTO.bookToDTO(book));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookPut book)
    {
        if (string.IsNullOrEmpty(book.Title))
        {
            return TypedResults.BadRequest($"Title can not be empty!");
        }

        var updatedBook = await bookRepository.UpdateBook(id, book);

        if (updatedBook == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(BookWithAuthorAndPublisherDTO.bookToDTO(updatedBook));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
    {
        var deletedBook = await bookRepository.DeleteBook(id);

        if (deletedBook == null)
        {
            return TypedResults.NotFound($"Id: {id} not found!");
        }

        return TypedResults.Ok(BookWithAuthorAndPublisherDTO.bookToDTO(deletedBook));
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
            return TypedResults.NotFound($"Publisher Id: {book.PublisherId} not found!");
        }

        foreach (var id in book.AuthorIds)
        {
            createdBook = await bookRepository.AddAuthorToBook(createdBook, id);
            if (createdBook == null) return TypedResults.NotFound($"AuthorId: {id} not found!");
        }

        int newId = await bookRepository.GetNewId();

        return TypedResults.Created($"/{newId}", BookWithAuthorAndPublisherDTO.bookToDTO(createdBook));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> AddAuthorToBook(IBookRepository bookRepository, int id, int AuthorId)
    {
        var book = await bookRepository.GetBookById(id);

        if (book == null)
        {
            return TypedResults.NotFound($"Book Id: {id} not found!");
        }

        book = await bookRepository.AddAuthorToBook(book, AuthorId);

        if (book == null)
        {
            return TypedResults.NotFound($"Author Id: {AuthorId} not found!");
        }

        return TypedResults.Ok(BookWithAuthorAndPublisherDTO.bookToDTO(book));
    }

    [ProducesResponseType(StatusCodes.Status200OK)]
    private static async Task<IResult> RemoveAuthorFromBook(IBookRepository bookRepository, int id, int AuthorId)
    {
        var book = await bookRepository.GetBookById(id);

        if (book == null)
        {
            return TypedResults.NotFound($"Book Id: {id} not found!");
        }

        book = await bookRepository.RemoveAuthorFromBook(book, AuthorId);

        if (book == null)
        {
            return TypedResults.NotFound($"Author Id: {AuthorId} not found!");
        }

        return TypedResults.Ok(BookWithAuthorAndPublisherDTO.bookToDTO(book));
    }
}
