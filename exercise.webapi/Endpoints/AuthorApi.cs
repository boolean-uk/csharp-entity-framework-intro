using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/GetAll", GetAuthors);
            authors.MapGet("/GetById{id}", GetAnAuthor);
            authors.MapPut("/AssignAuthor{authorId} To {bookId}", AssignAuthor);
            authors.MapPut("/RemoveAuthor{authorId} From {bookId}", RemoveAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            try
            {
                var result = await repository.GetAllAuthors();
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAnAuthor(IAuthorRepository repository, int id)
        {
            try
            {
                var result = await repository.GetAuthor(id);
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> AssignAuthor(IAuthorRepository authorRepository, IBookRepository bookRepository, int authorId, int bookId)
        {
            try
            {
                //Author doesn't exist
                var authorCheck = authorRepository.GetAuthor(authorId);
                if (authorCheck.IsFaulted)
                {
                    return TypedResults.NotFound();
                }

                //Book doesn't exist
                var bookCheck = bookRepository.GetBook(bookId);
                if (bookCheck.IsFaulted)
                {
                    return TypedResults.NotFound();
                }

                var author = await authorRepository.GetAuthor(authorId);
                //Check if the author already has the book assigned
                foreach (var authBook in author.Books)
                {
                    if(authBook.Id == bookId)
                    {
                        return TypedResults.BadRequest();
                    }
                }

                //Assign the author
                var result = await authorRepository.AssignAuthor(bookId, authorId);
                return TypedResults.Ok(result);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> RemoveAuthor(IAuthorRepository authorRepository, IBookRepository bookRepository, int authorId, int bookId)
        {
            try
            {
                //Author doesn't exist
                var authorCheck = authorRepository.GetAuthor(authorId);
                if (authorCheck.IsFaulted)
                {
                    return TypedResults.NotFound();
                }

                //Book doesn't exist
                var bookCheck = bookRepository.GetBook(bookId);
                if (bookCheck.IsFaulted)
                {
                    return TypedResults.NotFound();
                }

                var author = await authorRepository.GetAuthor(authorId);
                //Check if the author already has the book assigned
                foreach (var authBook in author.Books)
                {
                    if (authBook.Id == bookId)
                    {
                        //Remove the author from the book
                        var result = await authorRepository.RemoveAuthor(bookId, authorId);
                        return TypedResults.Ok(result);
                    }
                }
                return TypedResults.BadRequest();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
    }
}
