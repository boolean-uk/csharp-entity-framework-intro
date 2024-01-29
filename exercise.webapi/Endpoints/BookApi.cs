using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{

    public record BookAuthorPutPayload(int author_id);
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var bookGroup = app.MapGroup("/book");
            bookGroup.MapGet("/", GetBooks);
            bookGroup.MapGet("/{id}", GetBook);
            bookGroup.MapPut("/{id}", UpdateBookAuthor);
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
                return TypedResults.NotFound($"id {id} can not be found");
            }
            return TypedResults.Ok(new BookResponseDTO(book));
        }
        
        private static async Task<IResult> UpdateBookAuthor(int id, BookAuthorPutPayload payload, IBookRepository bookRepository, IAuthorRepository authorRepository)
        {

            Book? book = await bookRepository.GetBookById(id);
            if ( book == null )
            {
                return TypedResults.NotFound($"id {id} can not be found");
            }
            Author? author = await authorRepository.GetAuthorById(payload.author_id);
            if ( author == null )
            {
                return TypedResults.NotFound($"id {payload.author_id} can not be found");
            }
            book.AuthorId = payload.author_id;

            bookRepository.SaveChanges();
            return TypedResults.Ok(new BookResponseDTO(book));
        }
    }
}
