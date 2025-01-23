using exercise.webapi.DTO;
using exercise.webapi.Exceptions;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class BookEndpoints
    {
        public static string Path { get; private set; } = "books";

        public static void ConfigureBooksEndpoints(this WebApplication app)
        {
            var group = app.MapGroup(Path);

            group.MapPost("/", CreateBook);
            group.MapGet("/", GetBooks);
            group.MapGet("/{id}", GetBook);
            group.MapPut("/{id}", UpdateBook);
            group.MapDelete("/{id}", DeleteBook);
        }
        public static async Task<IResult> CreateBook(IRepository<Book> bookRepository, IRepository<Author> authorRepository, BookPost entity)
        {
            try
            {
                Author author = await authorRepository.Get(entity.AuthorId);
                Book book = await bookRepository.Add(new Book
                {
                    Title = entity.Title,
                    AuthorId = entity.AuthorId,
                });
                return TypedResults.Ok(new BookView(
                    book.Id,
                    book.Title,
                    new AuthorInternal(
                        author.Id,
                        author.FirstName,
                        author.LastName,
                        author.Email
                    )
                ));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new {ex.Message});
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        public static async Task<IResult> GetBooks(IRepository<Book> repository)
        {
            try
            {
                IEnumerable<Book> books = await repository.GetAll();
                return TypedResults.Ok(books.Select(b =>
                {
                    return new BookView(
                        b.Id,
                        b.Title,
                        new AuthorInternal(
                            b.Author.Id,
                            b.Author.FirstName,
                            b.Author.LastName,
                            b.Author.Email
                        ));
                }));
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        public static async Task<IResult> GetBook(IRepository<Book> repository, int id)
        {
            try
            {
                Book book = await repository.Get(id);
                return TypedResults.Ok(new BookView(
                    book.Id,
                    book.Title,
                    new AuthorInternal(
                        book.Author.Id,
                        book.Author.FirstName,
                        book.Author.LastName,
                        book.Author.Email
                )));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        public static async Task<IResult> UpdateBook(IRepository<Book> bookRepository, IRepository<Author> authorRepository, int id, BookPut entity)
        {
            try
            {
                Book book = await bookRepository.Get(id);
                if (entity.Title != null) book.Title = entity.Title;
                if (entity.AuthorId != null)
                {
                    Author author = await authorRepository.Get(entity.AuthorId.Value);
                    book.AuthorId = author.Id;
                }

                Book b = await bookRepository.Update(book);
                return TypedResults.Ok(new BookView(
                    b.Id,
                    b.Title,
                    new AuthorInternal(
                        b.Author.Id,
                        b.Author.FirstName,
                        b.Author.LastName,
                        b.Author.Email
                )));
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        public static async Task<IResult> DeleteBook(IRepository<Book> repository, int id)
        {
            try
            {
                Book book = await repository.Delete(id);
                return TypedResults.Ok(new { Message = $"Deleted Book with Title = {book.Title}" });
            }
            catch (IdNotFoundException ex)
            {
                return TypedResults.NotFound(new { ex.Message });
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
