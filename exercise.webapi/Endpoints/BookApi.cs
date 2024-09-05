using exercise.webapi.DtoModels;
using exercise.webapi.DTOModels;
using exercise.webapi.Models;
using exercise.webapi.Repository;
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
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var bookDtos = new List<BookDto>();

            foreach(var b in books)
            {
                bookDtos.Add(new BookDto(b, new AuthorDto(b.Author)));
            }

            return TypedResults.Ok(bookDtos);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetSingleBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetSingleBook(id);
            var bookDto = new BookDto(book, new AuthorDto(book.Author));
            return TypedResults.Ok(book);
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
            var bookUpdatedDto = new BookDto(bookUpdated, new AuthorDto(bookUpdated.Author));
            return TypedResults.Created("", bookUpdated);
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
            var bookDto = new BookDto(bookDeleted, new AuthorDto(bookDeleted.Author));
            return TypedResults.Ok(bookDto);
        }
    }
}
