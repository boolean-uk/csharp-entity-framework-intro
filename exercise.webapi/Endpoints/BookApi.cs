using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books/getAllBooks", GetAllBooks);
            app.MapGet("/books/getABook{id}", GetBook);
            app.MapPut("/books/UpdateAuthor{id}", UpdateBook);
            app.MapDelete("/books/DeleteABook{id}", DeleteBook);
            app.MapPost("/books/createABook", CreateBook);
        }


        private static async Task<IResult> GetAllBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            return TypedResults.Ok(book);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookUpdateData updateData)
        {
            var book = await bookRepository.UpdateBook(id, updateData);
            return TypedResults.Ok(book);

        }
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            return TypedResults.Ok(await bookRepository.DeleteBook(id));
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPostPayload bookData)
        {
            bool result = await bookRepository.checkBookDataID(bookData);
            if (!result)
            {
                
                return TypedResults.NotFound();
            }

            if (bookData.title == null || bookData.title == "")
            {
                return TypedResults.BadRequest();
            }

            var book = await bookRepository.CreateBook(bookData);
            
           
            return TypedResults.Ok(book);
        }




    }
}
