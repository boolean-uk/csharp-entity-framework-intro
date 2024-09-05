using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var books = app.MapGroup("authors");
            books.MapGet("/", GetAllAuthors);
            books.MapGet("/{id}", GetAuthorById);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAllAuthors(IAuthorRepository authorRepository)
        {
            var authorClasses = await authorRepository.GetAllAuthors();

            List<AuthorResponseDTO> authorDTOs = new List<AuthorResponseDTO>();

            foreach (var authorClass in authorClasses)
            {
                var authorDTO = new AuthorResponseDTO
                {
                    Id = authorClass.Id,
                    FirstName = authorClass.FirstName,
                    LastName = authorClass.LastName,
                    Email = authorClass.Email,
                    Books = authorClass.BookAuthors.Select(ba => new BookDTO
                    {
                        Title = ba.Book.Title,
                        Publisher = new PublisherDTO
                        {
                            Name = ba.Book.Publisher.Name
                        }
                    }).ToList()
                };
                authorDTOs.Add(authorDTO);
            }

            return TypedResults.Ok(authorDTOs);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            var authorClass = await authorRepository.GetAuthorById(id);

            var authorDTO = new AuthorResponseDTO
            {
                Id = authorClass.Id,
                FirstName = authorClass.FirstName,
                LastName = authorClass.LastName,
                Email = authorClass.Email,
                Books = authorClass.BookAuthors.Select(ba => new BookDTO
                {
                    Title = ba.Book.Title,
                    Publisher = new PublisherDTO
                    {
                        Name = ba.Book.Publisher.Name
                    }
                }).ToList()
            };

            return TypedResults.Ok(authorDTO);
        }
    }
}
