using exercise.webapi.Data;
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
            bookGroup.MapDelete("/{id}", DeleteBook);
            bookGroup.MapPost("/author/{authorId}", AddBook);


            

           
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
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

        private static async Task<IResult> DeleteBook(int id, IBookRepository bookRepository)
        {
            Book? book = await bookRepository.DeleteBookById(id);
            if (book == null)
            {
                return TypedResults.NotFound($"id {id} could not be found");
            }
            return TypedResults.Ok(new BookResponseDTO(book));
            throw new NotImplementedException();
        }

        private static async Task<IResult> AddBook(int authorId, IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostPayload payload)
        {
            try
            {
                var isAuthor = authorRepository.GetAuthorById(authorId);
                if (isAuthor == null) // Id lesser than 0 is invalid
                {
                    return TypedResults.NotFound($"Author id {authorId} is invaid");
                }
                if (payload.title == null || payload.title == "")
                {
                    return TypedResults.BadRequest($"Invalid payload {payload}");
                }
                var result = await bookRepository.AddBook(payload, authorId);
                return TypedResults.Created($"/author/{authorId}",new BookResponseDTO(result));
            } catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }
      
        


    }
}
