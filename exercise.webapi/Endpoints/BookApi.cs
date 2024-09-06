using exercise.webapi.DtoModels;
using exercise.webapi.DtoModels.BookApiDtos;
using exercise.webapi.DtoModels.PublisherDtos;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id:int}", GetSingleBook);
            app.MapPut("/books/{id:int}", UpdateBook);
            app.MapDelete("/books{id:int}", DeleteBook);
            app.MapPost("/books", CreateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var bookDtos = new List<BookDto>();

            foreach(var b in books)
            {
                bookDtos.Add(new BookDto(b, new BookAuthorDto(b.Author), b.Publisher.Name));
            }

            return TypedResults.Ok(bookDtos);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetSingleBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetSingleBook(id);
            var bookDto = new BookDto(book, new BookAuthorDto(book.Author), book.Publisher.Name);
            return TypedResults.Ok(bookDto);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            var bookUpdated = await bookRepository.UpdateBook(id, authorId);
            if(bookUpdated == null)
            {
                return TypedResults.BadRequest("Author or book does not exist");
            }
            var bookUpdatedDto = new BookDto(bookUpdated, new BookAuthorDto(bookUpdated.Author), bookUpdated.Publisher.Name);
            return TypedResults.Created("", bookUpdatedDto);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var bookDeleted = await bookRepository.DeleteBook(id);
            if (bookDeleted == null)
            {
                return TypedResults.NotFound("Book does not exist");
            }
            var bookDto = new BookDto(bookDeleted, new BookAuthorDto(bookDeleted.Author), bookDeleted.Publisher.Name);
            return TypedResults.Ok(bookDto);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPostModel bookModel)
        {
            //I assume you add a pre-existing author
            Book bookAdded = await bookRepository.CreateBook(bookModel);
            if(bookAdded == null)
            {
                TypedResults.BadRequest("Author does not exist");
            }

            BookInPublisherDto bookDto = new BookInPublisherDto(bookAdded, new BookAuthorDto(bookAdded.Author));
            return TypedResults.Created("",bookDto);
        }
    }
}
