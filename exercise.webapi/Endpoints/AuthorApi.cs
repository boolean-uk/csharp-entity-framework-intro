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
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors{id}", GetOneAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            GetAuthorResponse authorResponse = new GetAuthorResponse();
            var authors = await authorRepository.GetAllAuthors();

            foreach (Author author in authors)
            {
                DTOAuthor dtoauthor = new DTOAuthor() { ID = author.Id, Name = $"{author.FirstName} {author.LastName}", Email = author.Email };
                foreach (Book book in author.Books)
                {
                    dtoauthor.books.Add(book.Title);
                }

                authorResponse.authors.Add(dtoauthor);
            }

            return TypedResults.Ok(authorResponse);
        }

        [Route("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetOneAuthor(int id, IAuthorRepository authorRepository)
        {
            var author = await authorRepository.GetOneAuthor(id);

            if (author == null)
            {
                return TypedResults.NotFound(new Message());
            }

            DTOAuthor dtoauthor = new DTOAuthor() { ID = author.Id, Name = $"{author.FirstName} {author.LastName}", Email = author.Email };
            foreach (Book book in author.Books)
            {
                dtoauthor.books.Add(book.Title);
            }

            return TypedResults.Ok(dtoauthor);
        }

    }
}