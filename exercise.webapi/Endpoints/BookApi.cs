using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer;
using exercise.webapi.Models.DataTransfer.Books;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var mapGroup = app.MapGroup("books");

            mapGroup.MapGet("/", GetBooks);
            mapGroup.MapGet("/{id}", GetSpecificBook);
            mapGroup.MapPut("/{id}", PutBook);
            mapGroup.MapPost("/", PostBook);
            mapGroup.MapDelete("/", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooks(IRepository<Book, Author> repo)
        {
            var books = await repo.GetAllT();
            // .Select(b => new BookDTO(b.Id, b.Title, b.AuthorId, b.Author) // Cast from Book object to BookDTO);
            IEnumerable<BookDTO> results = books.ToList().Select(b => new BookDTO(b.Id, b.Title, b.Author, b.Publisher)).ToList();
            Payload<IEnumerable<BookDTO>> payload = new Payload<IEnumerable<BookDTO>>(results);
            return TypedResults.Ok(payload); 
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetSpecificBook(IRepository<Book, Author> repo, int id)
        {
            //.Select(b => new BookDTO(b.Id, b.Title, b.AuthorId, b.Author)) // Cast from Book object to BookDTO
            var book = await repo.Get(id);
            if (book == null) 
            {
                return TypedResults.NotFound("No book of provided Id could be found.");
            }
            BookDTO bookOut = new BookDTO(book.Id, book.Title, book.Author, book.Publisher);

            Payload<BookDTO> payload = new Payload<BookDTO>(bookOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutBook(IRepository<Book, Author> repo, IRepository<Publisher, Book> repo2, int id, BookInputDTO bookPut)
        {
            IEnumerable<Book> books = repo.GetAllT().Result;
            IEnumerable<Author> authors = repo.GetAllS().Result;
            IEnumerable<Publisher> publishers = repo2.GetAllT().Result;

            bool validId = books.Any(b => b.Id == id);
            if (!validId)
            {
                return TypedResults.NotFound($"Book with id {id} does not exist.");
            }
            bool validAuthorId = authors.Any(a => a.Id == bookPut.AuthorId);
            if (!validAuthorId)
            {
                return TypedResults.NotFound($"Author with id {bookPut.AuthorId} does not exist.");
            }
            bool validPublisherId = publishers.Any(a => a.Id == bookPut.PublisherId);
            if (!validPublisherId) 
            {
                return TypedResults.NotFound($"Publisher with id {bookPut.PublisherId} does not exist.");
            }

            Book inputBook = new Book() { Title = bookPut.Title, AuthorId = bookPut.AuthorId, PublisherId = bookPut.PublisherId};

            // Set values of the book
            Book? dbBook = books.Where(b => b.Id == id).FirstOrDefault();

            inputBook.Title = bookPut.Title ?? dbBook.Title;
            inputBook.AuthorId = bookPut.AuthorId;
            Author author = authors.Where(a => a.Id == bookPut.AuthorId).FirstOrDefault();
            inputBook.Author = author;
            Publisher publisher = publishers.Where(a => a.Id == bookPut.PublisherId).FirstOrDefault();
            inputBook.Publisher = publisher;

            Book result = await repo.Update(id, inputBook);

            BookDTO bookTransfer = new BookDTO(result.Id, result.Title, result.Author, result.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(bookTransfer);
            return TypedResults.Created($"/books/{id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> PostBook(IRepository<Book, Author> repo, IRepository<Publisher, Book> repo2, BookInputDTO bookPost) 
        {

            IEnumerable<Book> books = repo.GetAllT().Result;
            IEnumerable<Author> authors = repo.GetAllS().Result;
            IEnumerable<Publisher> publishers = repo2.GetAllT().Result;

            // Validate input
            bool validAuthorId = authors.Any(a => a.Id == bookPost.AuthorId);
            if (!validAuthorId) 
            {
                return TypedResults.NotFound($"Author Id {bookPost.AuthorId} was not found.");
            }
            bool validPublisherId = publishers.Any(a => a.Id == bookPost.PublisherId);
            if (!validPublisherId)
            {
                return TypedResults.NotFound($"Publisher with id {bookPost.PublisherId} does not exist.");
            }
            bool invalidBookName = books.Any(b => b.Title == bookPost.Title);
            if (invalidBookName)
            {
                return TypedResults.BadRequest($"""Book object not valid, a book with title "{bookPost.Title}" already exists.""");
            } else if (bookPost.Title == null || bookPost.Title == "") 
            {
                return TypedResults.BadRequest($"""Book object not valid, you must supply a valid title.""");
            }

            // Retrieve the book update
            #pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
            Author author = authors.Where(a => a.Id == bookPost.AuthorId).FirstOrDefault();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Book validatedBook = new Book() { Title = bookPost.Title, AuthorId = bookPost.AuthorId, Author = author };

            // Insert the book
            Book result = await repo.Insert(validatedBook);
            Payload<Book> payload = new Payload<Book>(result);

            return TypedResults.Created($"/books/{result.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IRepository<Book, Author> repo, int id) 
        {
            IEnumerable<Book> books = repo.GetAllT().Result;
            bool isValidId = books.Any(b => b.Id == id);
            if (isValidId) 
            {
                Book book = await repo.Delete(id);
                Payload<Book> payload = new Payload<Book>(book);
                return TypedResults.Ok(payload);
            } 
            else
            {
                return TypedResults.NotFound($"No entry with the id {id} could be found.");
            }
        }
    }
}
