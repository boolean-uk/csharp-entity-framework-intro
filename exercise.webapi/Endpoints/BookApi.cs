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
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{title}", GetABook);
            books.MapPut("/{title}", UppdateBook);
            books.MapPost("/", AddBook);
            books.MapDelete("/", DeleteBook);
            
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

        private static async Task<IResult> UppdateBook(IBookRepository bookRepository, string title, string newTitle) 
        {
            var book = await bookRepository.UppdateBook(title, newTitle);
            return TypedResults.Ok(ConvertToDTOList.ConvertToBOOKDT(book));
        }

        private static async Task<IResult> AddBook(IBookRepository bookRepository, string title, string authorFirstName, string authorLastName)
        {
            var book = await bookRepository.AddBook(title, authorFirstName, authorLastName);
            return TypedResults.Ok(ConvertToDTOList.ConvertToBOOKDT(book));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, string title)
        {
            var book = await bookRepository.DeleteBook(title);
            return TypedResults.Ok(ConvertToDTOList.ConvertToBOOKDT(book));
        }
    }
}
