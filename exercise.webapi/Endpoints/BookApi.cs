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
            //Load book
            var book = await bookRepository.GetBook(id);
            //Check if book exists otherwise return notFound
            if (book == null)
            {
                return TypedResults.NotFound($"No book found with id: {id}!");
            }
            //Insert book into DTO and return ok
            var result = new GetBookDTO(book);
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookUpdatePayload updateData)
        {
            //Load book to update
            var book = await bookRepository.GetBook(id);
            //Check if book exists otherwise return notFound
            if (book == null )
            {
                return TypedResults.NotFound($"No book found with id: {id}!");
            }
            //Run repository method
            book = await bookRepository.UpdateBook(id, updateData.authorId);
            //Insert book into DTO and return ok
            var result = new GetBookDTO(book);
            return TypedResults.Created($"/book{book.Id}", result);
        }
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            //Load book to delete
            var book = await bookRepository.GetBook(id);
            //Check if book exists otherwise return notFound
            if (book == null)
            {
                return TypedResults.NotFound($"No book found with id: {id}!");
            }
            //Run repository method
            book = await bookRepository.DeleteBook(id);
            //Insert book into DTO and return ok
            var result = new GetBookDTO(book);
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostPayload newBook)
        {
            //Check PostPayload if valid
            if (newBook.title == null || newBook.title == string.Empty || newBook.authorId == null || newBook.authorId == 0)
            {
                //if title is null/empty: throw error
                return TypedResults.BadRequest("All fields must contain data!");
            }
            //Load author for payload id
            Author? author = await authorRepository.GetAuthor(newBook.authorId);
            if (author == null)
            {
                //if author id is not found: throw error
                return TypedResults.NotFound($"No author with id: {newBook.authorId}!");
            }
            //create Book and add PostPayload info to book
            var book = new GetBookDTO(await bookRepository.CreateBook(newBook.title, newBook.authorId));
            return TypedResults.Created($"/book{book.Id}", book);
        }
    }
}
