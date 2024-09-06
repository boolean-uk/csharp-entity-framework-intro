using exercise.webapi.DTOs.AuthorApi;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAnAuthor);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            GetAuthorsResponse response = new GetAuthorsResponse();

            var authors = await authorRepository.GetAllAuthors();

            foreach (Author a in authors)
            {

                List<BookDTO> authorBooks = new List<BookDTO>();

                foreach (Book book in a.Books)
                {
                    BookDTO dtobook = new BookDTO(book.Title);
                    authorBooks.Add(dtobook);
                }
                var authorname = a.FirstName + " " + a.LastName;
                AuthorDTO author = new AuthorDTO(authorname, a.Email, authorBooks);

                response.Authors.Add(author);
            }


            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAnAuthor(IAuthorRepository authorRepository, int authorid)
        {
            Author getAuthor = await authorRepository.GetAuthor(authorid);

            if (getAuthor != null) 
            {
                var authorname = getAuthor.FirstName + " " + getAuthor.LastName;
                List<BookDTO> authorBooks = new List<BookDTO>();

                foreach (Book book in getAuthor.Books)
                {
                    BookDTO dtobook = new BookDTO(book.Title);
                    authorBooks.Add(dtobook);
                }

                AuthorDTO author = new AuthorDTO(authorname, getAuthor.Email, authorBooks);

                return TypedResults.Ok(author);
            }

            return TypedResults.NotFound("No author matches given author ID");

        }
    }
}
