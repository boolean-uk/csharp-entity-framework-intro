using exercise.webapi.AlternativeModels;
using exercise.webapi.Conversions;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
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
            var book = await bookRepository.UpdateBook(id, authorId);

            var member = BookConversion.toBook(book);

            return TypedResults.Ok(member);
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id); 
            if (book == null) return TypedResults.NotFound("Book not found");

            var member = BookConversion.toBook(book);

            return TypedResults.Ok(member);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, PostBook postBook)
        {
            Payload<Book> book = await bookRepository.CreateBook(postBook);
            if( book.status == Status.NotFound) return TypedResults.NotFound("not found");
            if (book.status == Status.BadRequest) return TypedResults.BadRequest("Bad request");

            var member = BookConversion.toBook(book.data);

            return TypedResults.Ok(member);
        }

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
    }
}
