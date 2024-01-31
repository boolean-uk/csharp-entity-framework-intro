using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public class BookDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int authorID { get; set; }
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public BookDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            authorID = book.AuthorId;
            AuthorFirstName = book.Author.FirstName;
            AuthorLastName = book.Author.LastName;
        }


    }
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/getBooks", GetBooks);
            app.MapGet("/getBookByID", GetBookByID);
            app.MapPut("/updateBook", UpdateBookByID);
            app.MapDelete("/deleteBook", DeleteBookByID);
            app.MapPut("/newBook", CreateNewBook);
        }

        /*
        GET ALL THE BOOKS!
        */
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var results = new List<BookDTO>();
            foreach (var book in books)
            {
                results.Add(new BookDTO(book));
            }
            return TypedResults.Ok(results);
        }

        /*
        GET ONE OF THE BOOKS!
        */
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBookByID(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book != null)
            {
                BookDTO BookToReturn = new BookDTO(book);
                return TypedResults.Ok(BookToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }

        /*
        UPDATE A BOOK!
        */
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBookByID(IBookRepository bookRepository, int id, string firstName, string lastName)
        {
            var book = await bookRepository.UpdateBookByID(id, firstName, lastName);
            if (book != null)
            {
                BookDTO bookToReturn = new BookDTO(book);
                return TypedResults.Created("/updatedBook", bookToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }

        /*
        dELETE A BOOK!
        */
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBookByID(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBookByID(id);
            if (book != null)
            {
                BookDTO bookToReturn = new BookDTO(book);
                return TypedResults.Ok(bookToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }
        /*
        CREATE A BOOK!
        */

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateNewBook(IBookRepository bookRepository, string title, int authorID)
        {
            if (title == null)
            {
                return TypedResults.BadRequest("Invalid input data");
            }

            var books = await bookRepository.GetAllBooks();
            var bookAuthor = books.FirstOrDefault(a => a.AuthorId == authorID);

            if (bookAuthor != null)
            {
                var book = await bookRepository.CreateNewBook(title, authorID);
                BookDTO bookToReturn = new BookDTO(book);
                return TypedResults.Created("newBook", bookToReturn);
            }
            return TypedResults.NotFound("invalid authorID");
        }
    }
}