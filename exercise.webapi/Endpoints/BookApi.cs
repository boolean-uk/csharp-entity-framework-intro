using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/book/{id}", GetBook);
            app.MapPut("/book/{id}", UpdateBook);
            app.MapDelete("/book/{id}", DeleteBook);
            app.MapPost("/book/", CreateBook);

            app.MapGet("/authors", GetAuthors);
            app.MapGet("/author/{id}", GetAuthor);

            app.MapGet("/publishers", GetPublishers);
            app.MapGet("/publisher/{id}", GetPublisher);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(ILibraryRepository libraryRepository)
        {
            var books = await libraryRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(ILibraryRepository libraryRepository, int id)
        {
            if (await libraryRepository.GetBook(id) == null)
            {
                return TypedResults.NotFound("Book not found");
            }
            var book = await libraryRepository.GetBook(id);
            return TypedResults.Ok(book);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(ILibraryRepository libraryRepository, int bookId, int newAuthorId)
        {
            if (await libraryRepository.GetAuthor(newAuthorId) == null)
            {
                return TypedResults.NotFound("Author not found");
            }
            if (await libraryRepository.GetBook(bookId) == null)
            {
                return TypedResults.NotFound("Book not found");
            }
            var book = await libraryRepository.UpdateBook(bookId, newAuthorId);
            return TypedResults.Ok(book);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> DeleteBook(ILibraryRepository libraryRepository, int id)
        {
            var book = await libraryRepository.DeleteBook(id);
            return TypedResults.Ok(book);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(ILibraryRepository libraryRepository, BookCreateDto book, int authorId, int publisherId)
        {
            if(await libraryRepository.GetAuthor(authorId) == null)
            {
                return TypedResults.NotFound("Author not found");
            }
            if (await libraryRepository.GetPublisher(publisherId) == null)
            {
                return TypedResults.NotFound("Publisher not found");
            }
            var newBook = await libraryRepository.CreateBook(book, authorId, publisherId);
            var newBookDto = new BookDto(newBook);
            return TypedResults.Created($"/{newBook.Id}",newBookDto);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(ILibraryRepository libraryRepository)
        {
            var authors = await libraryRepository.GetAllAuthors();
            return TypedResults.Ok(authors);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(ILibraryRepository libraryRepository, int id)
        {
            var author = await libraryRepository.GetAuthor(id);
            return TypedResults.Ok(author);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublishers(ILibraryRepository libraryRepository)
        {
            var publishers = await libraryRepository.GetAllPublishers();
            return TypedResults.Ok(publishers);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetPublisher(ILibraryRepository libraryRepository, int id)
        {
            var publisher = await libraryRepository.GetPublisher(id);
            return TypedResults.Ok(publisher);
        }
    }
}
