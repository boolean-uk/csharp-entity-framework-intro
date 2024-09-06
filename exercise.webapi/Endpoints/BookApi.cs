using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        private static BookDTO MapToBookDTO(Book book)
        {
            if (book.Author is null)
            {
                return new BookDTO
                {
                    Id = book.Id,
                    Title = book.Title,
                    AuthorId = book.AuthorId,
                    Author = null
                };
            }
            return new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = $"{book.Author.FirstName} {book.Author.LastName}"
            };
        }
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetABook);
            books.MapPut("/{id}/{authorid}", UpdateAuthor);
            books.MapDelete("/{id}", DeleteBook);
            books.MapDelete("/{id}/{authorid}", RemoveAuthor);
        }


        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAll();
            List<BookDTO> result = (from book in books select MapToBookDTO(book)).ToList();
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetA(id);
            if (book == null) return TypedResults.NotFound("Book was not found");
            var bookdto = MapToBookDTO(book);
            return TypedResults.Ok(bookdto);
        }


        private static async Task<IResult> UpdateAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookid, int authorid) 
        {
            var book = await bookRepository.GetA(bookid);
            if (book is null) return TypedResults.NotFound("Book was not found");

            var author = await authorRepository.GetA(authorid);
            if (author is null) return TypedResults.NotFound("Author was not found");

            book.Author = author;
            book.AuthorId = authorid;
            await bookRepository.Update(book);

            return TypedResults.Ok(MapToBookDTO(book));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.Delete(id);
            return TypedResults.Ok(MapToBookDTO(book));
        }
        private static async Task<IResult> RemoveAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookid, int authorid)
        {
            var book = await bookRepository.GetA(bookid);
            if (book is null) return TypedResults.NotFound("Book was not found");
            if (book.Author == null) return TypedResults.BadRequest("Book has no author");
            if (book.AuthorId != authorid) return TypedResults.BadRequest($"Book does not have author of with id {authorid}. This book has author with id {book.AuthorId}");
            
            var author = await authorRepository.GetA(authorid);
            if (author is null) return TypedResults.NotFound("Author was not found");

            author.Books.Remove(book);
            await authorRepository.Update(author);

            book.Author = null;
            book.AuthorId = null;
            await bookRepository.Update(book);

            return TypedResults.Ok(MapToBookDTO(book));
        }


    }
}
