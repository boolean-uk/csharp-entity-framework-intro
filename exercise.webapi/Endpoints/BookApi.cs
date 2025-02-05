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
            var books = app.MapGroup("/books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPost("/", AddBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository repository)
        {
            var books = await repository.GetAllBooks();
            List<BookDTO> result = books.Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                AuthorId = b.AuthorId,
                Author = new AuthorDTO
                {
                    Id = b.Author.Id,
                    FirstName = b.Author.FirstName,
                    LastName = b.Author.LastName,
                    Email = b.Author.Email
            }}).ToList();
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> GetBook(IBookRepository repository, int id)
        {
            var book = await repository.GetBook(id);
            if (book == null) return TypedResults.NotFound("Not Found");
            BookDTO result = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> AddBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPost model)
        {
            if ( model.Title == null ||  model.AuthorId == null) return TypedResults.BadRequest();
            Author author = await authorRepository.GetAuthor(model.AuthorId);
            if (author == null) return TypedResults.NotFound("Author not found");

            Book book = new Book
            {
                Title = model.Title,
                AuthorId = model.AuthorId,
            };
            await bookRepository.AddBook(book);

            BookDTO result = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int id, BookPut model)
        {
            if (model.Title == null && model.AuthorId == null) return TypedResults.BadRequest();
            Author author = await authorRepository.GetAuthor((int)model.AuthorId);
            if (author == null) return TypedResults.NotFound("Author not found");
            Book book = await bookRepository.GetBook(id);
            
            book.AuthorId = (int)author.Id;
            await bookRepository.UpdateBook(book);

            BookDTO result = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };
            return TypedResults.Ok(result);
        }

        private static async Task<IResult> DeleteBook(IBookRepository repository, int id)
        {
            var book = await repository.GetBook(id);
            if (book == null) return TypedResults.NotFound("Not Found");
            if (!await repository.DeleteBook(id)) return TypedResults.NotFound("Not Found");
            BookDTO result = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };
            return TypedResults.Ok(result);
        }

    }
}
