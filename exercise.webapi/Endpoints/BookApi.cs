using exercise.webapi.AlternativeModels;
using exercise.webapi.Conversions;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("/books");

            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPost("/", CreateBook);

            var authors = app.MapGroup("/author");

            authors.MapGet("/{id}", GetAuthor);
            authors.MapGet("/", GetAuthors);

            var publishers = app.MapGroup("/publisher");

            publishers.MapGet("/", GetPublishers);
            publishers.MapGet("/{id}", GetPublisher);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();

            List<ABookDto> result = BookConversion.toBook(books.ToList());

            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);

            var member = BookConversion.toBook(book);
            return TypedResults.Ok(member);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            var book = await bookRepository.GetBook(id);
            book.AuthorId = authorId;
            await bookRepository.UpdateBook(book);

            var member = BookConversion.toBook(book);

            return TypedResults.Ok(member);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id); 
            if (book == null) return TypedResults.NotFound("Book not found");

            var member = BookConversion.toBook(book);

            return TypedResults.Ok(member);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, PostBook postBook)
        {
            // check if elements exist
            Book temporaryBook = BookConversion.toCreate(postBook);
            Publisher publisher = await bookRepository.GetPublisher(temporaryBook.PublisherId);
            Author author = await bookRepository.GetAuthor(temporaryBook.AuthorId);

            // if not throw fault
            if (author == null | publisher == null) 
                return TypedResults.NotFound("Wrong ID inputted");
            if (!postBook.Title.Any())
                return TypedResults.BadRequest("Bad title");

            // create element
            Book book = await bookRepository.CreateBook(temporaryBook);

            var member = BookConversion.toBook(book);

            return TypedResults.Ok(member);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthor(IBookRepository bookRepository, int id)
        {
            var author = await bookRepository.GetAuthor(id);
            if (author == null) return TypedResults.NotFound();

            return TypedResults.Ok();
        }

        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = await bookRepository.GetAuthors();

            List<AAuthorDto> result = AuthorConversion.toAuthor(authors);

            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetPublishers(IBookRepository bookRepository)
        {
            var publishers = await bookRepository.GetPublishers();

            List<APublisherDto> result = PublisherConversion.toPublisher(publishers);

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetPublisher(IBookRepository bookRepository, int id)
        {
            var publisher = await bookRepository.GetPublisher(id);
            if (publisher == null) return TypedResults.NotFound("id not found");

            APublisherDto publisherDto = PublisherConversion.toPublisher(publisher);

            return TypedResults.Ok(publisherDto);
        }
    }
}
