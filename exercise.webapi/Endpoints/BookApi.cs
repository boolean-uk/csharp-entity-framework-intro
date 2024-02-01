using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}/{authorId}", UpdateBook);
            books.MapDelete("/delete/{id}", DeleteBook);
            books.MapPost("/create", CreateBook);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            var book = await bookRepository.UpdateBook(id, authorId);
            BookDTO updatedBook = new BookDTO()
            {
                Id = id,
                Title = book.Title,
                authorId = book.AuthorId,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}",
                PublisherId = book.PublisherId,
                PublisherName = book.Publisher.Name,
            };
            return TypedResults.Ok(updatedBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);
            if (book == null)
            { return TypedResults.NotFound(); }
            return TypedResults.Ok(book);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authRepo, PostBook model, int authorId)
        {
            var authors = await authRepo.GetAllAuthors();
            if(!authors.Any(x => x.Id == authorId))
            {
                return TypedResults.NotFound();
            }
            if(string.IsNullOrEmpty(model.Title))
            {
                return TypedResults.BadRequest();
            }
            var book = await bookRepository.CreateBook(model, authorId);

            var bookDTO = new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                authorId = book.AuthorId,
                AuthorName = $"{book.Author.FirstName} {book.Author.LastName}"
            };
            return TypedResults.Ok(bookDTO);
        }
    }
}
