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
            books.MapGet("/{id}", GetBookById);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPost("/", CreateBook);
        }

        private static async Task<IResult> GetBooks(IRepository<Book> bookRepository)
        {
            //BookPaylaod<IEnumerable<Book>> payload = new();

            BookPaylaod<IEnumerable<Book>> payload = new();

            var books = await bookRepository.GetAllEntities();

            payload.Data = books.ToList();

            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> GetBookById(IRepository<Book> bookRepository, int id)
        {
            BookPaylaod<Book> payload = new()
            {
                Data = await bookRepository.GetEntityById(id),
            };

            payload.Message = (payload.Data is null) ? "No book matching provided ID" : "OK";

            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> UpdateBook(IRepository<Book> bookRepository, IRepository<Author> authorRepository, int id, BookPut model)
        {
            var book = await bookRepository.GetEntityById(id);
            if (book == null) return TypedResults.NotFound("No book matching provided ID");

            try
            {
                book.Author = await authorRepository.GetEntityById(model.AuthorId);
                book.AuthorId = model.AuthorId;

                bookRepository.SaveRepository();
            }
            catch (Exception ex) { return TypedResults.BadRequest(ex); }

            BookPaylaod<Book> payload = new()
            {
                Data = book
            };

            return TypedResults.Ok(payload);
        }

        private static async Task<IResult> DeleteBook(IRepository<Book> bookRepository, int id)
        {
            try
            {
                var book = await bookRepository.GetEntityById(id);
                if (book == null) return TypedResults.NotFound("No book matching provided ID");

                var status = await bookRepository.DeleteEntity(book);
                bookRepository.SaveRepository();

                return TypedResults.Ok(status);

            } catch (Exception ex) { return TypedResults.BadRequest(ex); }
        }


        private static async Task<IResult> CreateBook(IRepository<Book> bookRepository, IRepository<Author> authorRepository, BookPost model)
        {
            try
            {   
                var allBooks = await bookRepository.GetAllEntities();

                Book book = new Book() 
                { 
                    Id = allBooks.Max(b => b.Id) + 1,
                    Title = model.Title,
                    Author = await authorRepository.GetEntityById(model.AuthorId),
                    AuthorId = model.AuthorId
                };

                BookPaylaod<Book> payload = new()
                {
                    Data = book
                };

                return TypedResults.Ok(payload);

            }
            catch (Exception ex) { return TypedResults.BadRequest(ex); }
        }
    }
}
