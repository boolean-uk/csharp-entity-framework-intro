using exercise.webapi.DTOs;
using exercise.webapi.Extensions;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
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
            List<BookDTO> result = (from book in books select book.MapToBookDTO()).ToList();
            return TypedResults.Ok(result);
        }
        private static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetA(id);
            if (book == null) return TypedResults.NotFound("Book was not found");
            var bookdto = book.MapToBookDTO();
            return TypedResults.Ok(bookdto);
        }


        private static async Task<IResult> UpdateAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookid, int authorid) 
        {
            var book = await bookRepository.GetA(bookid);
            if (book is null) return TypedResults.NotFound("Book was not found");

            var author = await authorRepository.GetA(authorid);
            if (author is null) return TypedResults.NotFound("Author was not found");

            book.Authors.Add(author);
            await bookRepository.Update(book);

            return TypedResults.Ok(book.MapToBookDTO());
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.Delete(id);
            return TypedResults.Ok(book.MapToBookDTO());
        }
        private static async Task<IResult> RemoveAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookid, int authorid)
        {
            var book = await bookRepository.GetA(bookid);
            if (book is null) return TypedResults.NotFound("Book was not found");
            if (book.Authors.Count == 0) return TypedResults.BadRequest("Book has no author");

            var author = await authorRepository.GetA(authorid);
            if (author is null) return TypedResults.NotFound("Author was not found");
            if (book.Authors.Contains(author)) return TypedResults.BadRequest($"Book does not have author of with id {authorid}.");
            

            author.Books.Remove(book);
            await authorRepository.Update(author);

            book.Authors.Remove(author);
            await bookRepository.Update(book);

            return TypedResults.Ok(book.MapToBookDTO());
        }


    }
}
