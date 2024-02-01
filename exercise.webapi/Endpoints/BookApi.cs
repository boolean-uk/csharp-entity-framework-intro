using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using System.Net;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/{id}", GetBook);
            app.MapPut("/{id}", UpdateBook);
            app.MapDelete("/{id}", DeleteBook);
            app.MapPost("/", CreateBook);
            app.MapPut("/{id}/Add-Author", AddAuthor);
            app.MapPut("/{id}/Remove-Author", RemoveAuthor);
        }

        private async static Task<IResult> AddAuthor(IBookRepository bookRepository, int id, int Authorid)
        {

            return TypedResults.Ok(await bookRepository.AssignAuthor(id, Authorid));

        }
        private async static Task<IResult>RemoveAuthor(IBookRepository bookRepository, int id)
        {

            return TypedResults.Ok(await bookRepository.RemoveAuthor(id));
        }


        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id )
        {
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(book);
        }
        private static async Task <IResult>UpdateBook(IBookRepository bookRepository, int id,  int AuthorId)
        {
            return TypedResults.Ok(await bookRepository.UpdateAuthor( id, AuthorId));
        }
        private static async Task <IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            return TypedResults.Ok(await bookRepository.DeleteBook(id));
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, CreateBookDto dto)
        {
            try
            {
                return TypedResults.Created(nameof(CreateBook), await bookRepository.CreateBook(dto));
            }
            catch (ArgumentException ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
            catch (BadHttpRequestException ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }
    }
}
