using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Runtime.CompilerServices;
using System.Web.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/author", GetAuthors);
            app.MapGet("/author/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(AuthorRepository authorRepository, IEnumerable<AuthorDTO> list)
        {
            var authors = await authorRepository.GetAllAuthors();
            var authorDTOs = authors.Select(b => new AuthorDTO
            {
                fullName = b.FirstName + " " + b.LastName,
                email = b.Email,
                Id = b.Id,

            }).ToList();
            return TypedResults.Ok(authorDTOs);
        }
        private static async Task<IResult> GetAuthor(AuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            AuthorDTO authorDTO = new AuthorDTO()
            {
                fullName = author.FirstName + " " + author.LastName,
                email = author.Email,
                Id = author.Id,
            };
            return TypedResults.Ok(author);
        }

    }
}
