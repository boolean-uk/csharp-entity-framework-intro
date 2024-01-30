using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;
using exercise.webapi.DTO;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Diagnostics;

namespace exercise.webapi.Endpoints
{
    public record UpdateBookAuthorRequestDTO(List<int> authorId);
    public record CreateBookRequestDTO(string title, List<int> authorId);

    [ApiController]
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapPost("/books", CreateBook);
            app.MapGet("/books/{id}", GetBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPut("/books/{bookId}/author/", UpdateBookAuthor);
            app.MapDelete("/books/{bookId}/author/{authorId}", DeleteBookAuthor);

            app.UseExceptionHandler(c => c.Run(async context =>
            {
                var exception = context.Features
                    .Get<IExceptionHandlerFeature>()
                    ?.Error;
                if (exception is not null)
                {
                    var response = new { error = exception.Message };
                    context.Response.StatusCode = 400;

                    await context.Response.WriteAsJsonAsync(response);
                }
            }));
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();

            return TypedResults.Ok(BookResponseDTO.FromRepository(books));
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int bookId)
        {
            var book = await bookRepository.GetBook(bookId);
           
            return TypedResults.Ok(new BookDTO(book));
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorsRepository authorsRepository, CreateBookRequestDTO payload)
        {
            if (payload.authorId.GetType() != typeof(int) || payload.title.GetType() != typeof(string))
            {
                return TypedResults.BadRequest();
            }


            
            var bk = await bookRepository.GetAllBooks();

            int maxim = bk.OrderByDescending(u => u.Id).FirstOrDefault().Id;

            var book = new Book();
            book.Id = maxim + 1;
          
            book.Title = payload.title;


            foreach(int el in payload.authorId)
            {
                var auth = await authorsRepository.GetAuthor(el);

                if (auth == null)
                {
                    return TypedResults.NotFound("Not found!");
                }

                book.BookAuthors.Add(new BookAuthor() { AuthorId = el, BookId = book.Id });
            }
         

            bookRepository.AddBook(book);

            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookDTO(book));
        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookId)
        {
            var book = await bookRepository.DeleteBook(bookId);

            if (book == null) 
            { 
                return TypedResults.NotFound();
            }

            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookDTO(book));
        }

        public static async Task<IResult> UpdateBookAuthor(int bookId, UpdateBookAuthorRequestDTO payload, 
            IBookRepository bookRepository, IAuthorsRepository authorsRepository)
        {
         
            Book? book = await bookRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }

            
            foreach (int el in payload.authorId)
            {
                Author? author = await authorsRepository.GetAuthor(el);

                if (author == null)
                {
                    return TypedResults.NotFound();
                }

                book.BookAuthors.Add(new BookAuthor() {  AuthorId = el, BookId  = book.Id } );
            }
        

            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }

        public static async Task<IResult> DeleteBookAuthor(int bookId, int authId,  IBookRepository bookRepository, IAuthorsRepository authorsRepository)
        {

            Book? book = await bookRepository.GetBook(bookId);
            if (book == null)
            {
                return TypedResults.NotFound();
            }


            
            Author? author = await authorsRepository.GetAuthor(authId);

            if (author == null)
            {
                 return TypedResults.NotFound();
            }

            BookAuthor ba = book.BookAuthors.Where(x => x.BookId == book.Id).First(x => x.AuthorId == author.Id);

            book.BookAuthors.Remove(ba);
           
            bookRepository.SaveChanges();

            return TypedResults.Ok(new BookResponseDTO(book));
        }
    }
}
