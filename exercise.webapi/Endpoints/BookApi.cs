using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{title}", GetABook);
            //app.MapPut("/books/{title}", UppdateBook)
            
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            
            var books = await bookRepository.GetAllBooks();

            return TypedResults.Ok(ConvertToDTOList.ConvertToBOOKDTOList(books));
        }

        private static async Task<IResult> GetABook(IBookRepository bookRepository, string title)
        {
            var book = await bookRepository.GetABook(title);
            return TypedResults.Ok(ConvertToDTOList.ConvertToBOOKDT(book));
        }

      //  private static async Task<IResult> 
    }
}
