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
            app.MapGet("/books/{id}", GetBookByID);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books/{id}", CreateBook);
            app.MapGet("authors", GetAuthors);
            app.MapGet("authors/{id}", GetAuthorByID);
        }
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var results = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                results.Add(new BookResponseDTO(book));
            }
            return TypedResults.Ok(results);
        }
        private static async Task<IResult> GetBookByID(IBookRepository bookRepository, int id)
        {
            var books = await bookRepository.GetBookbyId(id);
            if (books is null) return TypedResults.NotFound();
            BookResponseDTO result = new BookResponseDTO(books);
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int authorId)
        {
            try
            {
                var books = await bookRepository.UpdateBook(id, authorId);
                if (books is null) return TypedResults.NotFound("Book doesn't exist");
                BookResponseDTO result = new BookResponseDTO(books);
                return TypedResults.Ok(result);
            }
            catch(Exception)
            {
                return TypedResults.NotFound("Author doesn't exist");
            }
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            bool result = await bookRepository.DeleteBook(id);
            if (result) return TypedResults.Ok("The book has successfully been deleted");
            return TypedResults.NotFound($"Book {id} doesn't exist");
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPostPayload data)
        {
            Book book = await bookRepository.CreateBook(data);
            BookResponseDTO result = new BookResponseDTO(book);
            return TypedResults.Created("", result);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            var results = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorResponseDTO(author));
            }
            return TypedResults.Ok(results);
        }

        private static async Task<IResult> GetAuthorByID(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthorbyID(id);
            if (author is null) return TypedResults.NotFound();
            AuthorResponseDTO result = new AuthorResponseDTO(author);
            return TypedResults.Ok(result);
        }

    }
}
