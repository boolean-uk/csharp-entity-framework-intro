using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {

        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            List<AuthorResponseDTO> authordtos = new List<AuthorResponseDTO>();
            var authors = await authorRepository.GetAllAuthors();

            foreach (var author in authors)
            {
                AuthorResponseDTO authorDTO = new AuthorResponseDTO();
                authorDTO.Id = author.Id;
                authorDTO.FirstName = author.FirstName;
                authorDTO.LastName = author.LastName;
                authorDTO.Email = author.Email;

                foreach (var book in author.Books)
                {
                    BookDTO bookDTO = new BookDTO();
                    bookDTO.Id = book.Id;
                    bookDTO.Title = book.Title;
                    bookDTO.AuthorId = book.AuthorId;
                    bookDTO.AuthorName = book.Author.FirstName + " " + book.Author.LastName;
                    authorDTO.Books.Add(bookDTO);
                }

                authordtos.Add(authorDTO);
            }
            return TypedResults.Ok(authordtos);
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);

            if (author == null)
            {
                return TypedResults.NotFound();
            }

            AuthorResponseDTO authorDTO = new AuthorResponseDTO();
            authorDTO.Id = author.Id;
            authorDTO.FirstName = author.FirstName;
            authorDTO.LastName = author.LastName;
            authorDTO.Email = author.Email;

            foreach (var book in author.Books)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Id = book.Id;
                bookDTO.Title = book.Title;
                bookDTO.AuthorId = book.AuthorId;
                bookDTO.AuthorName = book.Author.FirstName + " " + book.Author.LastName;
                authorDTO.Books.Add(bookDTO);
            }
            

            return TypedResults.Ok(authorDTO);
        }




    }
}
    
