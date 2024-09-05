using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors" , GetAuthors);
            app.MapGet("/authors/{id}" , GetAuthorById);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            var authorResponseDTOs = authors.Select(author => MapToAuthorResponseDTO(author)).ToList();
            return TypedResults.Ok(authorResponseDTOs);
        }

        private static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository , int id)
        {
            var author = await authorRepository.GetAuthorById(id);
            if(author == null)
                return Results.NotFound();

            var authorResponseDTO = MapToAuthorResponseDTO(author);
            return TypedResults.Ok(authorResponseDTO);
        }

        private static AuthorResponseDTO MapToAuthorResponseDTO(Author author)
        {
            if(author == null)
            {
                return new AuthorResponseDTO();
            }

            return new AuthorResponseDTO
            {
                Id = author.Id ,
                FirstName = author.FirstName ,
                LastName = author.LastName ,
                Email = author.Email ,
                Books = author.Books.Select(MapToBookResponseDTO).ToList()
            };
        }

        private static BookResponseDTO MapToBookResponseDTO(Book book)
        {
            return new BookResponseDTO
            {
                Id = book.Id ,
                Title = book.Title ,
            };
        }
    }
}
