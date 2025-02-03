using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/authors", GetAuthorById);
            authors.MapGet("/", GetAllAuthors);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository)
        {

            try
            {
                var authors = await authorRepository.GetAllAuthors();

                var bookDtos = authors.Select(x => new AuthorDTO
                {
                    Name = $"{x.FirstName} {x.LastName}",
                    Email = x.Email,
                    Books = x.Books.Select(b => new AuthorWithBooks
                    {
                        Title = b.Title,
                        PublisherName = b.Publisher.Name,
                    }).ToList()

                }).ToList();


                return TypedResults.Ok(bookDtos);
            }

            catch (Exception ex)
            {

                return TypedResults.BadRequest(ex.Message);

            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthorById(id);

            if (author == null) 
                return TypedResults.NotFound($"Author with id {id} does not exist");


            var authorDto = new AuthorDTO
            {
                Name = $"{author.FirstName} {author.LastName}",
                Email = author.Email,
                Books = author.Books.Select(b => new AuthorWithBooks
                {
                    Title = b.Title,
                    PublisherName = b.Publisher.Name
                }).ToList()
            };
            return TypedResults.Ok(authorDto);
        }

    }
}
