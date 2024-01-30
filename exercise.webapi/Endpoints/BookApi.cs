using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Identity;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/book", GetBook);
            app.MapPut("/book", UpdateBook);
            app.MapDelete("/book", DeleteBook);
            app.MapPost("/book", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = GetBookDTO.FromRepository(await bookRepository.GetAllBooks());
            return TypedResults.Ok(books);
        }
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = new GetBookDTO(await bookRepository.GetBook(id));
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookUpdatePayload updateData)
        {
            var book = new GetBookDTO(await bookRepository.UpdateBook(id, updateData));
            return TypedResults.Created($"/book", book);
        }
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var bookToDie = new GetBookDTO(await bookRepository.DeleteBook(id));
            return TypedResults.Ok(bookToDie);
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostPayload newBook)
        {
            //Check PostPayload if valid
            if (newBook.title == null || newBook.title == string.Empty || newBook.authorId == null)
            {
                //if title is null/empty: throw error
                return TypedResults.BadRequest();
            }
            //Load author for payload id
            Author? author = await authorRepository.GetAuthor(newBook.authorId);
            if (author == null)
            {
                //if author id is not found: throw error
                return TypedResults.NotFound();
            }
            //create Book and add PostPayload info to book
            var book = new GetBookDTO(await bookRepository.CreateBook(newBook));
            return TypedResults.Created($"/book", book);
        }
    }
}
