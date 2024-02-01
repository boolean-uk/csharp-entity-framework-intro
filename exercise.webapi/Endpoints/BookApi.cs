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
        private static async Task<IResult> GetBooks(IRepository<Book> repo)
        {
            var books = await repo.GetAll();
            // .Select(b => new BookDTO(b.Id, b.Title, b.AuthorId, b.Author) // Cast from Book object to BookDTO);
            IEnumerable<BookDTO> results = books.ToList().Select(b => new BookDTO(b.Id, b.Title, b.Author, b.Publisher)).ToList();
            Payload<IEnumerable<BookDTO>> payload = new Payload<IEnumerable<BookDTO>>(results);
            return TypedResults.Ok(payload); 
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetSpecificBook(IRepository<Book> repo, int id)
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
        private static async Task<IResult> PutBook(IRepository<Book> bookRepo, IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo, int id, BookInputDTO bookPut)
        {
            IEnumerable<Book> books = bookRepo.GetAll().Result;
            IEnumerable<Author> authors = authorRepo.GetAll().Result;
            IEnumerable<Publisher> publishers = publisherRepo.GetAll().Result;

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

            Book inputBook = new Book() { AuthorId = bookPut.AuthorId, PublisherId = bookPut.PublisherId};

            // Set values of the book
            Book? dbBook = books.Where(b => b.Id == id).FirstOrDefault();

            inputBook.Id = dbBook.Id;
            inputBook.Title = bookPut.Title ?? dbBook.Title;
            Author author = authors.Where(a => a.Id == bookPut.AuthorId).FirstOrDefault();
            Publisher publisher = publishers.Where(a => a.Id == bookPut.PublisherId).FirstOrDefault();
            inputBook.Author = author;
            inputBook.Publisher = publisher;

            Book result = await bookRepo.Update(id, inputBook);

            BookDTO bookTransfer = new BookDTO(result.Id, result.Title, result.Author, result.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(bookTransfer);
            return TypedResults.Created($"/books/{id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> PostBook(IRepository<Book> bookRepo, IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo, BookInputDTO bookPost) 
        {

            IEnumerable<Book> books = bookRepo.GetAll().Result;
            IEnumerable<Author> authors = authorRepo.GetAll().Result;
            IEnumerable<Publisher> publishers = publisherRepo.GetAll().Result;

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
            Publisher publisher = publishers.Where(p => p.Id == bookPost.PublisherId).FirstOrDefault();
            #pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
            Book validatedBook = new Book() { Title = bookPost.Title, AuthorId = bookPost.AuthorId, Author = author, PublisherId = publisher.Id, Publisher = publisher};

            // Insert the book
            Book insertedBook = await bookRepo.Insert(validatedBook);
            BookDTO bookTransfer = new BookDTO(insertedBook.Id, insertedBook.Title, insertedBook.Author, insertedBook.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(bookTransfer);

            return TypedResults.Created($"/books/{insertedBook.Id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IRepository<Book> repo, int id) 
        {
            IEnumerable<Book> books = repo.GetAll().Result;
            bool isValidId = books.Any(b => b.Id == id);
            if (isValidId) 
            {
                Book book = await repo.Delete(id);
                BookDTO bookTransfer = new BookDTO(book.Id, book.Title, book.Author, book.Publisher);
                Payload<BookDTO> payload = new Payload<BookDTO>(bookTransfer);
                return TypedResults.Ok(payload);
            } 
            else
            {
                return TypedResults.NotFound($"No entry with the id {id} could be found.");
            }
        }
    }
}
