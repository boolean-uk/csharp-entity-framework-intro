using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("/authors");

            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAuthors();
            List<AuthorResponseDTO> authorsDTO = new List<AuthorResponseDTO>();
            foreach (var author in authors)
            {
                authorsDTO.Add(author.ToDTOResponse());
            }
            return TypedResults.Ok(authorsDTO);
        }
        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return TypedResults.NotFound($"Author with id {id} was not found");
            }
            return TypedResults.Ok(author.ToDTOResponse());
        }
    }
}
