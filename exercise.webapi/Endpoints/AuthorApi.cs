using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var author = app.MapGroup("authors");
            author.MapGet("/", GetAuthors);
            author.MapGet("/{id}", GetAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            var result = new AuthorDTO()
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,  
                Books = []
            };

            foreach (var b in author.Books)
            {
                BookPublisherDTO bookDTO = new BookPublisherDTO()
                {
                    Id = b.Id,
                    Title = b.Title,
                    PublisherName = b.Publisher.Name
                };
                result.Books.Add(bookDTO);
            }

            return TypedResults.Ok(result);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            var result = new List<AuthorDTO>();

            foreach (var a in authors)
            {
                var authorDTO = new AuthorDTO()
                {
                    Id = a.Id,
                    FirstName = a.FirstName,
                    LastName = a.LastName,
                    Email = a.Email,
                    Books = []
                };

                foreach(var b in a.Books)
                {
                    BookPublisherDTO bookDTO = new BookPublisherDTO()
                    {
                        Id = b.Id,
                        Title = b.Title,
                        PublisherName = b.Publisher.Name
                    };
                    authorDTO.Books.Add(bookDTO);
                }
                result.Add(authorDTO);
            }

            return TypedResults.Ok(result);
        }

    }
}
