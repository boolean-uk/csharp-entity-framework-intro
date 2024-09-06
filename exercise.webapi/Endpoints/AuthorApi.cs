using exercise.webapi.CreateModels;
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
            app.MapGroup("Author");
            app.MapGet("/", GetAuthors);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            /*
            GetAuthorResponce response = new();

            var authors = await authorRepository.GetAllAuthors();

            foreach (Author author in authors)
            {
                GetAuthorModel a = new();
                a.AuthorName = author.FirstName + " " + author.LastName;

                foreach (Book book in author.Books)
                {
                    a.BookTitles.Add(book.Title);
                }

                response.Authors.Add(a);
            }

            //return TypedResults.Ok(response);
            */
            return TypedResults.Ok();
        }
    }
}
