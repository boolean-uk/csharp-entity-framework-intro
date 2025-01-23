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
            app.MapGet("/books/{id}", GetBookById);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books/", CreateBook);
        }
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPost bookPost)
        {
            if (!bookRepository.AuthorExists(bookPost.AuthorId))
            {
                return TypedResults.NotFound("Author id not valid");
            }
            // in repository check if obj is value and return data based on this
            var result = await bookRepository.CreateBook(bookPost);

            BookDTO bookDTO = new BookDTO()
            {
                Title = result.Title,
                Author = new AuthorDTO
                {
                    Id = result.Author.Id,
                    FirstName = result.Author.FirstName,
                    LastName = result.Author.LastName,
                    Email = result.Author.Email,
                }
            };
            return TypedResults.Ok(bookDTO);
        }
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var result = await bookRepository.GetBookById(id);
            BookDTO bookDTO = new BookDTO()
            {
                Title = result.Title,
                Author = new AuthorDTO
                {
                    Id = result.Author.Id,
                    FirstName = result.Author.FirstName,
                    LastName = result.Author.LastName,
                    Email = result.Author.Email,
                }
            };
            await bookRepository.DeleteBookById(id);

            return TypedResults.Ok(bookDTO);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookId, AuthorPut authorPut)
        {
            var result = await bookRepository.UpdateAuthorByBookId(bookId, authorPut);
            BookDTO bookDTO = new BookDTO()
            {
                Title = result.Title,
                Author = new AuthorDTO
                {
                    Id = result.Author.Id,
                    FirstName = result.Author.FirstName,
                    LastName = result.Author.LastName,
                    Email = result.Author.Email,
                }
            };
            return TypedResults.Ok(bookDTO);
        }

        private static async Task<IResult> GetBookById(IBookRepository bookRepository, int id)
        {
            var result = await bookRepository.GetBookById(id);
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var results = await bookRepository.GetAllBooks();
            return TypedResults.Ok(results);
        }
    }
}
