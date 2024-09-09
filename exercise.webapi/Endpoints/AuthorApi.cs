using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("author");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{Firstname, Lastname}", GetAuthorByName);
            authors.MapDelete("/{FirstName, LastName, id}", RemoveAuthorFromBook);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            GetAuthorsResponse response = new GetAuthorsResponse();

            var results = await authorRepository.GetAllAuthors();

            foreach (var a in results)
            {
                DTOAuthorApi author = new DTOAuthorApi();
                author.Name = a.FirstName + " " + a.LastName;
                author.Email = a.Email;

                foreach (Book book in a.Books)
                {
                    DTOAuthorBook b = new DTOAuthorBook();
                    b.Title = book.Title;
                    b.Id = book.Id;
                    author.books.Add(b);
                }
                response.Authors.Add(author);
            }
            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthorByName(IAuthorRepository authorRepository ,string FirstName, string LastName)
        {
            var exists = await authorRepository.GetAuthorByName(FirstName, LastName);
            if (exists == null)
            {
                return TypedResults.NotFound("No such author");
            }
            else
            {
                DTOAuthorApi foundAuthor = new DTOAuthorApi();
                foundAuthor.Name = FirstName + " " + LastName;
                foundAuthor.Email = exists.Email;
                
                foreach (Book book in exists.Books)
                {
                    DTOAuthorBook b = new DTOAuthorBook();
                    b.Title = book.Title;
                    b.Id = book.Id;
                    foundAuthor.books.Add(b);
                }

                return TypedResults.Ok(foundAuthor);
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> RemoveAuthorFromBook(IAuthorRepository authorRepository, IBookRepository bookRepository, string FirstName, string LastName, int id)
        {
            var book = await bookRepository.GetBookById(id);
            var toRemove = await authorRepository.GetAuthorByName(FirstName, LastName);
            if (toRemove == null || book == null)
            {
                return TypedResults.NotFound("Book or author not found");
            }
            else
            {
                if (book.AuthorId == toRemove.Id)
                {
                    book.AuthorId = null;
                    await bookRepository.UpdateById(book.Id, book);
                    return TypedResults.Ok("Removed " + toRemove.FirstName + " " + toRemove.LastName + " as Author for " + book.Title);

                }
                else
                {
                    return TypedResults.NotFound("Provided author did not write this book");
                }
            }
        }
    }
}
