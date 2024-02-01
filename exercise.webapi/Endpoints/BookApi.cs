using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var bookGroup = app.MapGroup("/books");
            bookGroup.MapGet("/", GetBooks);
            bookGroup.MapGet("/{id}", GetBook);
            bookGroup.MapPut("/{id}", UpdateBook);
            bookGroup.MapDelete("/{id}", DeleteBook);
            bookGroup.MapPost("/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            List<BookDTO> booksDTO = new List<BookDTO>();
            foreach (var book in books)
            {
                booksDTO.Add(CreateBookDTO(book));
            }
            return TypedResults.Ok(booksDTO);
        }
        private static async Task<IResult> GetBook(IRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            return TypedResults.Ok(CreateBookDTO(book));
        }
        private static async Task<IResult> UpdateBook(IRepository bookRepository, int id, int NewAuthorId)
        {
            var book = await bookRepository.UpdateBook(id,NewAuthorId);
            return TypedResults.Ok(CreateBookDTO(book));
        }
        private static async Task<IResult> DeleteBook(IRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBook(id);
            return TypedResults.Ok(CreateBookDTO(book));
        }
        private static async Task<IResult> CreateBook(IRepository bookRepository, InputBook newbook)
        {
            var result = await bookRepository.CreateBook(newbook);
            if (result == null) { return TypedResults.NotFound("ID not found"); }

            return TypedResults.Ok(CreateBookDTO(result));
        }
        private static BookDTO CreateBookDTO(Book book)
        {
            var bookDTO = new BookDTO();
            bookDTO.Id = book.Id;
            bookDTO.Title = book.Title;
            bookDTO.author = new AuthorBooklessDTO() { Email = book.Author.Email, FirstName = book.Author.FirstName, LastName = book.Author.LastName };
            return bookDTO;
        }
    }
}
