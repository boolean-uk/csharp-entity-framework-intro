using exercise.webapi.DTOs.BookApi;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var books = app.MapGroup("books");
            books.MapGet("/", GetBooks);
            books.MapGet("/{id}", GetBook);
            books.MapPut("/{id}", UpdateBook);
            books.MapDelete("/{id}", DeleteBook);
            books.MapPost("/{id}", AddBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            GetBooksResponse response = new GetBooksResponse();
            var books = await bookRepository.GetAllBooks();

            foreach (Book b in books)
            {
                DTOAuthor author = new DTOAuthor(b.Author.FirstName + " " + b.Author.LastName);
                DTOBook book = new DTOBook(b.Title, author);

                response.Books.Add(book);

            }

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetBook(IBookRepository bookRepository, int bookid)
        {
            Book book = await bookRepository.GetABook(bookid);
            if(book != null)
            {
                DTOAuthor author = new DTOAuthor(book.Author.FirstName + " " + book.Author.LastName);
                DTOBook dtobook = new DTOBook(book.Title, author);
                return TypedResults.Ok(dtobook);
            }
            
            return TypedResults.NotFound("No book matches given book ID");
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int bookid, int authorid)
        {
            
            try
            {
                Book getbook = await bookRepository.GetABook(bookid);
                getbook.AuthorId = authorid;
                
                Book updatedbook = await bookRepository.UpdateBook(getbook);

                DTOAuthor author = new DTOAuthor(updatedbook.Author.FirstName + " " + updatedbook.Author.LastName);
                DTOBook dtobook = new DTOBook(updatedbook.Title, author);

                return TypedResults.Ok(dtobook);
            }
            catch (Exception ex) 
            {
                return TypedResults.Problem(ex.Message);
            }
            
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IBookRepository bookRepository, int bookid)
        {
            Book deleteBook = await bookRepository.DeleteBook(bookid);
            if(deleteBook != null)
            {
                DTOAuthor author = new DTOAuthor(deleteBook.Author.FirstName + " " + deleteBook.Author.LastName);
                DTOBook dtoBook = new DTOBook(deleteBook.Title, author);
                return TypedResults.Ok(dtoBook);
            }
            
            return TypedResults.NotFound();
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> AddBook(IBookRepository bookRepository, BookPostModel bookmodel)
        {
            Book newbook = await bookRepository.AddBook(bookmodel);
            
            DTOAuthor author = new DTOAuthor(newbook.Author.FirstName + " " + newbook.Author.LastName);
            DTOBook dtoBook = new DTOBook(newbook.Title, author);
            
            return TypedResults.Ok(dtoBook);
        }
    }
}
