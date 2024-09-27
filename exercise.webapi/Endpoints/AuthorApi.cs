using exercise.webapi.AlternativeModels;
using exercise.webapi.Conversions;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorssApi(this WebApplication app)
        {
            var authors = app.MapGroup("/author");

            authors.MapGet("/{id}", GetAuthor);
            authors.MapGet("/", GetAuthors);
            authors.MapPut("/{id}", AddAuthor);
            authors.MapDelete("/{id}", RemoveAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null) return TypedResults.NotFound();

            return TypedResults.Ok();
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAuthors();

            List<AAuthorDto> result = AuthorConversion.toAuthor(authors);

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> AddAuthor(IAuthorRepository authorRepository, 
            IBookRepository bookRepository, IBookAuthorRepository bookAuthorRepository, int authorId, int bookId)
        {
            var author = await authorRepository.GetAuthor(authorId);
            var book = await bookRepository.GetBook(bookId);
            if ( book == null | author == null) return TypedResults.NotFound("Not found");

            var bookAuthor = await bookAuthorRepository.GetRelation(authorId, bookId);
            if (bookAuthor != null) return TypedResults.BadRequest("Relation already exists");

            var bookWitRelation = await bookAuthorRepository.CreateRelation(bookId, authorId);
                    

            return TypedResults.Ok(BookConversion.toBook(bookWitRelation));
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> RemoveAuthor(IAuthorRepository authorRepository,
            IBookRepository bookRepository, IBookAuthorRepository bookAuthorRepository, int authorId, int bookId)
        {
            var author = await authorRepository.GetAuthor(authorId);
            var book = await bookRepository.GetBook(bookId);
            if (book == null | author == null) return TypedResults.NotFound("Not found");

            var bookAuthor = await bookAuthorRepository.GetRelation(authorId, bookId);
            if (bookAuthor == null) return TypedResults.NotFound("Relation not found");

            var bookWitRelation = await bookAuthorRepository.DeleteRelation(bookAuthor);


            return TypedResults.Ok(BookConversion.toBook(bookWitRelation));
        }
    }
}
