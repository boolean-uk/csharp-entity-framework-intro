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
            var bookGroup = app.MapGroup("/book");
            bookGroup.MapGet("/", GetBooks);
            bookGroup.MapGet("/{id}", GetBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            //var books = await bookRepository.GetAllBooks();
            return TypedResults.Ok(BookResponseDTO.FromRepository(await bookRepository.GetAllBooks()));
        }

        private static async Task<IResult> GetBook(int id, IBookRepository bookRepository)
        {
            //throw new NotImplementedException();
            Book? book = await bookRepository.GetBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new BookResponseDTO(book));


        }
    }
}
