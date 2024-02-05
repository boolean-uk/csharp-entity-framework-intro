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
        private static async Task<IResult> AddAuthorToBook(IRepository<Author> authorRepo, IRepository<Book> bookRepo, int authorId, int bookId)
        {
            var author = await authorRepo.GetAll();
            var books = await bookRepo.GetAll();
            bool validAuthor = author.Any(a => a.Id == authorId);
            if (!validAuthor) 
            {
                return TypedResults.NotFound("The provided author id was invalid");
            }
            bool validBookId = books.Any(b => b.Id == bookId);
            if (!validBookId) 
            {
                return TypedResults.NotFound("The provided book id was invalid");
            }

            Book specifiedBook = books.Where(b => b.Id == bookId).FirstOrDefault();
            Author authorToAdd = author.Where(a => a.Id == authorId).FirstOrDefault();

            specifiedBook.Author = authorToAdd;
            specifiedBook.AuthorId = authorId;

            Book updatedBook = await bookRepo.Update(bookId, specifiedBook);

            BookDTO returnBook = new BookDTO(updatedBook.Id, updatedBook.Title, updatedBook.Author, updatedBook.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(returnBook);

            return TypedResults.Created($"/{returnBook.Id}", payload);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> RemoveAuthorFromBook(IRepository<Author> authorRepo, IRepository<Book> bookRepo, int authorId, int bookId)
        {
            var author = await authorRepo.GetAll();
            var books = await bookRepo.GetAll();
            bool validAuthor = author.Any(a => a.Id == authorId);
            if (!validAuthor)
            {
                return TypedResults.NotFound("The provided author id was invalid");
            }
            bool validBookId = books.Any(b => b.Id == bookId);
            if (!validBookId)
            {
                return TypedResults.NotFound("The provided book id was invalid");
            }

            Book specifiedBook = books.Where(b => b.Id == bookId).FirstOrDefault();
            // Author authorToRemove = author.Where(a => a.Id == authorId).FirstOrDefault(); // Keeping for many-to-many extension

            specifiedBook.Author = new Author() { Id = 0, FirstName = "", LastName = "", Email = ""};
            specifiedBook.AuthorId = 0;

            Book updatedBook = await bookRepo.Update(bookId, specifiedBook);

            BookDTO returnBook = new BookDTO(updatedBook.Id, updatedBook.Title, updatedBook.Author, updatedBook.Publisher);
            Payload<BookDTO> payload = new Payload<BookDTO>(returnBook);

            return TypedResults.Created($"/{returnBook.Id}", payload);

        }
    }
}
