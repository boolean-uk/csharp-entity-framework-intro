using AutoMapper;
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
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPost("/books", AddBook);
            app.MapPut("/books", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
        }

        private static async Task<IResult> GetBooks(IRepository<Book> repository, IMapper mapper)
        {
            try
            {
                var books = await repository.GetAll(b => b.Author);
                var response = mapper.Map<IEnumerable<BookDto>>(books);
                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            }
        }

        private static async Task<IResult> GetBook(IRepository<Book> repository, IMapper mapper, int id)
        {
            try
            {
                var book = await repository.Get(b => b.Id.Equals(id), b => b.Author);
                if (book == null) return TypedResults.NotFound($"Book with {id} was not found");
                return TypedResults.Ok(mapper.Map<BookDto>(book));
            }
            catch (Exception ex) 
            {
                return TypedResults.BadRequest(ex);
            }
        }

        private static async Task<IResult> AddBook(IRepository<Book> repository, IRepository<Author> authorRepository, IMapper mapper, AddBookDto model)
        {
            try
            {
                var author = await authorRepository.Get(a => a.Id.Equals(model.AuthorId));
                if (author == null) return TypedResults.NotFound($"Author with {model.AuthorId} was not found");

                Book newBook = new Book
                {
                    Title = model.Title,
                    AuthorId = model.AuthorId,
                    Author = author,
                };
                var book = await repository.Add(newBook);
                return TypedResults.Created($"https://localhost:7054/books/", mapper.Map<BookDto>(book));
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            }
        }

        private static async Task<IResult> UpdateBook(IRepository<Book> repository, IMapper mapper, int bookId, int authorId)
        {
            try
            {
                var book = await repository.Get(b => b.Id.Equals(bookId));
                if (book == null) return TypedResults.NotFound($"Book with {bookId} was not found");
                book.AuthorId = authorId;
                await repository.Update(book);
                var updatedBookWithInclude = await repository.Get(b => b.Id.Equals(bookId), b => b.Author);
                return TypedResults.Ok(mapper.Map<BookDto>(updatedBookWithInclude));
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            }
        }

        private static async Task<IResult> DeleteBook(IRepository<Book> repository, IMapper mapper, int bookId)
        {
            try
            {
                var book = await repository.Get(b => b.Id.Equals(bookId), b => b.Author);
                if (book == null) return TypedResults.NotFound($"Book with {bookId} was not found");
                await repository.Delete(book);

                return TypedResults.Ok(mapper.Map<BookDto>(book));
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            }
        }
    }
}
