using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Models.DataTransfer;
using exercise.webapi.Models.DataTransfer.Books;
using exercise.webapi.Models.JunctionModels;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Net;

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
            IEnumerable<BookDTO> results = books.ToList().Select(b => new BookDTO(b.BookId, b.Title, b.GetAuthors(), b.Publisher)).ToList();
            Payload<IEnumerable<BookDTO>> payload = new Payload<IEnumerable<BookDTO>>(results);
            return TypedResults.Ok(payload); 
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetSpecificBook(IRepository<Book> repo, int id)
        {
            var book = await repo.Get(id);
            if (book == null) 
            {
                return TypedResults.NotFound("No book of provided BookId could be found.");
            }
            BookDTO bookOut = new BookDTO(book.BookId, book.Title, book.GetAuthors(), book.Publisher);

            Payload<BookDTO> payload = new Payload<BookDTO>(bookOut);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> PutBook(IRepository<Book> bookRepo, IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo, IRepository<BookAuthor> baRepo, int id, BookInputDTO bookPut)
        {
            IEnumerable<BookAuthor> ba = await baRepo.GetAll();

            if (await bookRepo.Get(id) == null)
            {
                return TypedResults.NotFound($"Book with id {id} does not exist.");
            }
            if (await authorRepo.Get(id) == null)
            {
                return TypedResults.NotFound($"Author with id {bookPut.AuthorId} does not exist.");
            }
            if (await publisherRepo.Get(id) == null) 
            {
                return TypedResults.NotFound($"Publisher with id {bookPut.PublisherId} does not exist.");
            }

            Author auth = await authorRepo.Get(id);

            ICollection<BookAuthor> bookAuthors = bookPut.AuthorId
                .Select(a => new BookAuthor() { 
                    AuthorId = a, 
                    Author = auth,
                })
                .ToList();
            Book inputBook = new Book() { BookAuthors = bookAuthors, PublisherId = bookPut.PublisherId};

            // Set values of the book
            Book? dbBook = await bookRepo.Get(id);

            inputBook.BookId = dbBook.BookId;
            inputBook.Title = bookPut.Title ?? dbBook.Title;
            Publisher publisher = await publisherRepo.Get(id);
            inputBook.Publisher = publisher;

            IEnumerable<BookAuthor> bookAuthorsOld = ba.Where(ba => ba.BookId == id && bookPut.AuthorId.Any(a => a == ba.AuthorId)).ToList();
            foreach (BookAuthor bookAuthor in bookAuthorsOld) 
            {
                await baRepo.Delete(bookAuthor);
            }

            Book result = await bookRepo.Update(id, inputBook);

            foreach (int val in bookPut.AuthorId)
            {
                Author putAuthor = await authorRepo.Get(id);
                BookAuthor newJunction = new BookAuthor()
                {
                    AuthorId = val,
                    Author = putAuthor,
                    BookId = result.BookId,
                    Book = result
                };
                baRepo.Insert(newJunction);
            }

            BookDTO bookTransfer = new BookDTO(result.BookId, result.Title, result.GetAuthors(), result.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(bookTransfer);
            return TypedResults.Created($"/books/{id}", payload);
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> PostBook(IRepository<Book> bookRepo, IRepository<Author> authorRepo, IRepository<Publisher> publisherRepo, BookInputDTO bookPost) 
        {

            IEnumerable<Book> books = await bookRepo.GetAll();
            IEnumerable<Author> authors = await authorRepo.GetAll();

            // Validate input
            bool validAuthorId = bookPost.AuthorId.All(ai => authors.Any(a => a.AuthorId == ai));
            if (!validAuthorId) 
            {
                return TypedResults.NotFound($"Author BookId {bookPost.AuthorId} was not found.");
            }

            if (await publisherRepo.Get(bookPost.PublisherId) == null)
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
            IEnumerable<Author> foundAuthors = authors.Where(a => bookPost.AuthorId.Contains(a.AuthorId)).ToList();
            Publisher publisher = await publisherRepo.Get(bookPost.PublisherId);
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.

            ICollection<BookAuthor> bookAuthors = bookPost.AuthorId
                .Select(a => new BookAuthor()
                {
                    AuthorId = a,
                    Author = authorRepo.Get(a).Result,
                })
                .ToList();

            Book validatedBook = new Book() { Title = bookPost.Title, BookAuthors = bookAuthors, PublisherId = publisher.Id, Publisher = publisher};

            // Insert the book
            Book insertedBook = await bookRepo.Insert(validatedBook);

            foreach (BookAuthor ba in bookAuthors)
            {
                ba.BookId = insertedBook.BookId;
                ba.Book = insertedBook;
            }

            BookDTO bookTransfer = new BookDTO(insertedBook.BookId, insertedBook.Title, insertedBook.GetAuthors(), insertedBook.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(bookTransfer);

            return TypedResults.Created($"/books/{insertedBook.BookId}", payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IRepository<Book> repo, int id) 
        {
            if (await repo.Get(id) != null) 
            {
                Book book = await repo.Delete(id);
                BookDTO bookTransfer = new BookDTO(book.BookId, book.Title, book.GetAuthors(), book.Publisher);
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
