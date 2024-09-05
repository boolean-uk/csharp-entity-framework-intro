
using exercise.webapi.DtoModels.AuthorApiDtos;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id:int}", GetSingleAuthor);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetSingleAuthor(IAuthorRepository repository, int id)
        {
            var author = await repository.GetSingleAuthor(id);
            AuthorDto authorDto = new AuthorDto(author);
            return TypedResults.Ok(authorDto);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            var authorList = await repository.GetAuthors();
            List<AuthorDto> authorDtoList = new List<AuthorDto>();

            foreach(var a in authorList)
            {
                authorDtoList.Add(new AuthorDto(a));
            }
            return TypedResults.Ok(authorDtoList);
        }
    }
}
