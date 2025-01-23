using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModel;
using Microsoft.EntityFrameworkCore.Update.Internal;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/book", Get);
            app.MapGet("/update", UpdateAuthor);
            app.MapGet("/delete", DeleteBook);
            app.MapGet("/create", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }
        public static async Task<IResult> Get(IBookRepository repo, int id)
        { 
            var book = await repo.GetBook(id);
            return TypedResults.Ok(book);   
        }

        public static async Task<IResult> UpdateAuthor(IBookRepository repository, int bookid, int authorid)
        {
            try
            {
                await repository.Update(bookid, authorid);
                var book = repository.GetBook(bookid);
                
                return TypedResults.Ok(book);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            } 
 
        }
        public static async Task<IResult> DeleteBook(IBookRepository repo, int bookid)
        {
            try
            {
                repo.Delete(bookid);
                return TypedResults.Ok();
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            } 
            
        }
        public static async Task<IResult> CreateBook(IBookRepository repo, string title, int authorid)
        {
            try
            {
                return TypedResults.Ok(await repo.CreateBook(title, authorid));
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            }
        }
    }
}
