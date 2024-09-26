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
            app.MapGet("/getabook/{id}", GetABook);
            app.MapPut("/updateBook/{id}", UpdateBook);
            app.MapPost("/createBook/{id}", CreateBook);
            app.MapDelete("/deleteBook/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            return TypedResults.Ok(BookResponseDTO.FromRepository(await bookRepository.GetAllBooks()));
        }

        private static async Task<IResult> GetABook(IBookRepository bookRepository, int bookid)
        {
            Book book = await bookRepository.GetABook(bookid);
            if (book == null)
            {
                return TypedResults.NotFound($"could not find book with id {bookid}");
            }
            return TypedResults.Ok(BookResponseDTO.FromRepository(book));
        }

        public static async Task<IResult> UpdateBook(int bookId,int authorId, int publisherId, IBookRepository bookRepository, IAuthorRepository authorsRepository, IPublisherRepository publisherRepository)
        {
            // get the book
            Book? book = await bookRepository.GetABook(bookId);
            if(book == null)
            {
                return TypedResults.NotFound();
            }
            Author? author = await authorsRepository.GetAnAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            
            book.PublisherId = publisherId;
            Publisher publisher = await publisherRepository.GetAPublisher(publisherId);
            book.Publisher = publisher;
            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book)); //i assume this fulfills task to return book and author since we get a book and the author inside the book? correct me if wrong
        }

        public static async Task<IResult> CreateBook(string title, int authorId, int publisherId, IBookRepository bookRepository, IAuthorRepository authorsRepository, IPublisherRepository publisherRepository)
        {
            Author? author = await authorsRepository.GetAnAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound("author not found");
            }
            Publisher? publisher = await publisherRepository.GetAPublisher(publisherId);
             if (publisher == null)
            {
                return TypedResults.NotFound("author not found");
            }
            Book book = await bookRepository.CreateBook(title, author, publisher);
            if (book == null)
            {
                return TypedResults.BadRequest("invalid input");
            }

            return TypedResults.Ok(new BookResponseDTO(book));
        }

        public static async Task<IResult> DeleteBook(int bookId, IBookRepository bookRepository)
        {
            Book book = await bookRepository.DeleteBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound($"Could not find book with id{bookId}");
            }
            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }
    }
}
