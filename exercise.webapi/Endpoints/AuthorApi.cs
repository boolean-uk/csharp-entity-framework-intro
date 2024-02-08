using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

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
        private static async Task<IResult> GetAllAuthors(IAuthorRepo authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            List<AuthorResponseDTO> authorDTOs = new List<AuthorResponseDTO>();

            foreach(var author in authors) 
            {
                var authorDTO = new AuthorResponseDTO
                {
                    Id = author.Id,
                    FirstName = author.FirstName,
                    LastName = author.LastName,
                    Email = author.Email,
                    Books = author.BookAuthors.Select(ba => new BookDTO
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
        private static async Task<IResult> GetAuthorById(IAuthorRepo authorrepository, int id)
        {
            var authorObject = await authorrepository.GetAuthorById(id);
            var authorDTO = new AuthorResponseDTO
            {
                Id = authorObject.Id,
                FirstName = authorObject.FirstName,
                LastName = authorObject.LastName,
                Email = authorObject.Email,
                Books = authorObject.BookAuthors.Select(ba => new BookDTO
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
