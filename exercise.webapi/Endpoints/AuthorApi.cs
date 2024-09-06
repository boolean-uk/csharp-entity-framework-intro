
using exercise.webapi.DTO;
using exercise.webapi.DTOS;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");

            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthorById);
        }

        public static async Task<IResult> GetAuthorById(IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAuthorById(id);

                DTOAuthorWithBooks dtoAuthor = new DTOAuthorWithBooks();
                dtoAuthor.Id = author.Id;
                dtoAuthor.FirstName = author.FirstName;
                dtoAuthor.LastName = author.LastName;
                dtoAuthor.Email = author.Email;

                foreach (Book book in author.Books) 
                {
                    DTOBookWithoutAuthor dtoBook = new DTOBookWithoutAuthor();
                    dtoBook.Id = book.Id;
                    dtoBook.Title = book.Title;

                    dtoAuthor.Books.Add(dtoBook);
                }

                return TypedResults.Ok(dtoAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        public static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            GetAllAuthorsResponse response = new GetAllAuthorsResponse();
            var authors = await authorRepository.GetAllAuthors();

            foreach (Author author in authors)
            {
                DTOAuthorWithBooks dtoAuthor = new DTOAuthorWithBooks();
                dtoAuthor.Id = author.Id;
                dtoAuthor.FirstName = author.FirstName;
                dtoAuthor.LastName = author.LastName;
                dtoAuthor.Email = author.Email;

                foreach (Book book in author.Books)
                {
                    DTOBookWithoutAuthor dtoBook = new DTOBookWithoutAuthor();
                    dtoBook.Id = book.Id;
                    dtoBook.Title = book.Title;

                    dtoAuthor.Books.Add(dtoBook);
                }

                response.Authors.Add(dtoAuthor);
            }

            return TypedResults.Ok(response.Authors);
        }
    }
}
