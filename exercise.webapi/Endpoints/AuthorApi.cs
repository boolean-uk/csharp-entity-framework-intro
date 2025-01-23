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
            var author = app.MapGroup("Author");
            author.MapGet("/", GetAuthors);
            author.MapGet("/{id}", GetAnAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {

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

            return TypedResults.Ok(response);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAnAuthor(IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAnAuthor(id);

                GetAuthorModel getAuthorModel = new()
                {
                    AuthorName = author.FirstName + " " + author.LastName,
                   
                };
                foreach (Book book in author.Books)
                {
                    getAuthorModel.BookTitles.Add(book.Title);
                }


                return TypedResults.Ok(getAuthorModel);
            }

            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }


    }
}
