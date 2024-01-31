using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{

    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public AuthorResponseDTO(Author author)
        {
            Id = author.Id;
            FirstName = author.FirstName;
            LastName = author.LastName;
        }
    }

    public static class AuthorApi
    {
        public static void configureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/getAuthors", GetAuthors);
            app.MapGet("/getAuthorByID", GetAuthorByID);

        }

        //Get all Authors
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            var results = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorResponseDTO(author));
            }
            return TypedResults.Ok(results);
        }

        
        //Get one author by ID 
        private static async Task<IResult> GetAuthorByID(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthorByID(id);
            if (author != null)
            {
                AuthorResponseDTO AuthorToReturn = new AuthorResponseDTO(author);
                return TypedResults.Ok(AuthorToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }
    }
}
