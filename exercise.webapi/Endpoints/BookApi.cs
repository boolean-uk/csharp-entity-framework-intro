using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    
    

    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int authorID {  get; set; } 
        public string AuthorFirstName { get; set; }
        public string AuthorLastName { get; set; }
        public int PublisherId { get; set; }
        public string PublisherName { get; set; }
        public BookResponseDTO(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            authorID = book.AuthorId;
            AuthorFirstName = book.Author.FirstName;
            AuthorLastName = book.Author.LastName;
            PublisherId = book.PublisherId;
            PublisherName = book.Publisher.Name;
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

        //Get all books
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

        //Get one book by ID
        private static async Task<IResult> GetBookByID(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBookById(id);
            if (book != null)
            {
                BookResponseDTO BookToReturn = new BookResponseDTO(book);
                return TypedResults.Ok(BookToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }

        //Update one book
        private static async Task<IResult> UpdateBookByID(IBookRepository bookRepository, int id, string firstName, string lastName)
        {
            var book = await bookRepository.UpdateBookByID(id, firstName,lastName);
            if (book != null)
            {
                BookResponseDTO bookToReturn = new BookResponseDTO(book);
                return TypedResults.Created("/updatedBook", bookToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }

        //Delete Book By ID
        private static async Task<IResult> DeleteBookByID(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.DeleteBookByID(id);
            if (book != null )
            {
                BookResponseDTO bookToReturn = new BookResponseDTO(book);
                return TypedResults.Ok(bookToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }
        //Create new book
        private static async Task<IResult> CreateNewBook(IBookRepository bookRepository, string title, int authorID, int publisherID)
        {
            if (title == null)
            {
                return TypedResults.BadRequest("Invalid input data");
            }

            var books = await bookRepository.GetAllBooks();
            var bookAuthor = books.FirstOrDefault(a => a.AuthorId == authorID);
            var bookPublisher = books.FirstOrDefault(a => a.PublisherId == publisherID);

            if (bookAuthor != null && bookPublisher != null)
            {
                var book = await bookRepository.CreateNewBook(title, authorID, publisherID);
                BookResponseDTO bookToReturn = new BookResponseDTO(book); 
                return TypedResults.Created("newBook", bookToReturn);
            }
            return TypedResults.NotFound("invalid authorID/publisherID");
        }
    }
}
