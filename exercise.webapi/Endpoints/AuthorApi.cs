using exercise.webapi.Models.DatabaseModels;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using exercise.webapi.Models.DataTransfer.Books;
using exercise.webapi.Models.DataTransfer.Authors;
using exercise.webapi.Models.DataTransfer;
using exercise.webapi.Models.JunctionModels;
using System.Net;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("author");

            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetSpecificAuthor);
            authorGroup.MapPut("/{bookId}", AddAuthorToBook);
            authorGroup.MapDelete("/{authorId}", RemoveAuthorFromBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthors(IRepository<Author> repo)
        {
            var authors = await repo.GetAll();
            IEnumerable<AuthorDTO> results = authors.ToList().Select(a => new AuthorDTO(a.AuthorId, a.FirstName, a.LastName, a.Email, a.GetBooks())).ToList();
            Payload<IEnumerable<AuthorDTO>> payload = new Payload<IEnumerable<AuthorDTO>>(results);
            return TypedResults.Ok(payload);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetSpecificAuthor(IRepository<Author> repo, int id)
        {
            var author = await repo.Get(id);
            if (author == null)
            {
                return TypedResults.NotFound("No author of provided BookId could be found.");
            }

            AuthorDTO authorOut = new AuthorDTO(author.AuthorId, author.FirstName, author.LastName, author.Email, author.GetBooks());

            Payload<AuthorDTO> payload = new Payload<AuthorDTO>(authorOut);
            return TypedResults.Ok(payload);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> AddAuthorToBook(IRepository<Author> authorRepo, IRepository<Book> bookRepo, IRepository<BookAuthor> baRepo, int authorId, int bookId)
        {
            var ba = await baRepo.GetAll();
            if (await authorRepo.Get(authorId) == null) 
            {
                return TypedResults.NotFound("The provided author id was invalid");
            }
            if (await bookRepo.Get(bookId) == null) 
            {
                return TypedResults.NotFound("The provided book id was invalid");
            }

            if (ba.Any(ba => (ba.BookId == bookId && ba.AuthorId == authorId))) 
            {
                return TypedResults.BadRequest("The author provided is already attributed to the provided book!");
            }

            // Find Bookauthor junction object and remove from both datbase and from reference objects
            BookAuthor bookAuthorJunction = new BookAuthor();
            Book specifiedBook = await bookRepo.Get(bookId);
            bookAuthorJunction.Book = specifiedBook;
            bookAuthorJunction.BookId = specifiedBook.BookId;
            specifiedBook.BookAuthors.Add(bookAuthorJunction);

            Author specifiedAuthor = await authorRepo.Get(authorId);
            bookAuthorJunction.Author = specifiedAuthor;
            bookAuthorJunction.AuthorId = specifiedAuthor.AuthorId;
            specifiedAuthor.BookAuthors.Add(bookAuthorJunction);

            // Update the database
            BookAuthor newBookAuthorJunction = await baRepo.Insert(bookAuthorJunction);
            Book updatedBook = await bookRepo.Update(bookId, specifiedBook);
            

            BookDTO returnBook = new BookDTO(updatedBook.BookId, updatedBook.Title, updatedBook.GetAuthors(), updatedBook.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(returnBook);

            return TypedResults.Created($"/{returnBook.Id}", payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> RemoveAuthorFromBook(IRepository<Author> authorRepo, IRepository<Book> bookRepo, IRepository<BookAuthor> baRepo, int authorId, int bookId)
        {
            var ba = await baRepo.GetAll();
            if (await authorRepo.Get(authorId) == null)
            {
                return TypedResults.NotFound("The provided author id was invalid");
            }
            if (await bookRepo.Get(bookId) == null)
            {
                return TypedResults.NotFound("The provided book id was invalid");
            }

            // Find Bookauthor junction object and remove from both datbase and from reference objects
            BookAuthor selectedBA = ba.Where(ba => ba.BookId == bookId && ba.AuthorId == authorId).FirstOrDefault();

            Book bookToRemoveFrom = selectedBA.Book;

            selectedBA.Author.BookAuthors.Remove(selectedBA);
            selectedBA.Book.BookAuthors.Remove(selectedBA);
            BookAuthor baRemoved = await baRepo.Delete(selectedBA);


            BookDTO returnBook = new BookDTO(bookToRemoveFrom.BookId, bookToRemoveFrom.Title, bookToRemoveFrom.GetAuthors(), bookToRemoveFrom.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(returnBook);

            return TypedResults.Created($"/{returnBook.Id}", payload);

        }
    }
}
