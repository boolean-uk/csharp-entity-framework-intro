using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static exercise.webapi.DTO.DTO;


namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/getAuthors", GetAuthors);
            app.MapGet("/getAuthorByID", GetAuthorByID);

        }

        /*
        GET ALL THE AUTHORS
         */
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            var results = new List<AuthorDTO>();
            foreach (var author in authors)
            {
                results.Add(new AuthorDTO(author));
            }
            return TypedResults.Ok(results);
        }


        /*
        GET AN AUTHOR BY ID
        */
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAuthorByID(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthorByID(id);
            if (author != null)
            {
                AuthorDTO AuthorToReturn = new AuthorDTO(author);
                return TypedResults.Ok(AuthorToReturn);
            }
            return TypedResults.BadRequest("/bad request");
        }
    }
}