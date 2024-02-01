using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("/authors");
            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IRepository repository)
        {
            var authors = await repository.GetAllAuthors();
            List<AuthorDTO> authorsDTOs = new List<AuthorDTO>();
            foreach (var author in authors)
            {
                authorsDTOs.Add(CreateAuthorDTO(author));
            }
            return TypedResults.Ok(authors);
        }
        private static async Task<IResult> GetAuthor(IRepository repository, int id)
        {
            var author = await repository.GetAuthorById(id);
            
            return TypedResults.Ok(CreateAuthorDTO(author));
        }
        private static AuthorDTO CreateAuthorDTO(Author author)
        {
            AuthorDTO authorDTO = new AuthorDTO();
            authorDTO.FirstName = author.FirstName;
            authorDTO.LastName = author.LastName;
            authorDTO.Email = author.Email;
            foreach (var book in author.Books)
            {
                BookAuthorlessDTO bookDTO = new BookAuthorlessDTO();
                bookDTO.Title = book.Title;
                bookDTO.Id = book.Id;
                authorDTO.Books.Add(bookDTO);
            }
            return authorDTO;
        }
        
    }
}
