using exercise.webapi.DTOs;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", getAuthors);
            app.MapGet("/authors/{id}", getAuthor);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> getAuthors(IAuthorRepository authorRepository)
        {
            try
            {
                var results = await authorRepository.GetAllAuthors();
                List<AuthorDTO> authors = new List<AuthorDTO>();
                foreach (var a in results)
                {
                    AuthorDTO authorDTO = new AuthorDTO();
                    authorDTO.Name = a.FirstName + " " + a.LastName;
                    authorDTO.Email = a.Email;
                    authorDTO.Books = new List<AuthorBookDTO>();

                    foreach (var b in a.Books)
                    {
                        AuthorBookDTO authorBookDTO = new AuthorBookDTO();
                        authorBookDTO.Title = b.Title;
                        authorDTO.Books.Add(authorBookDTO);
                    }
                    authors.Add(authorDTO);
                }
                return TypedResults.Ok(authors);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> getAuthor(IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAuthor(id);

                AuthorDTO authorDTO = new AuthorDTO();
                authorDTO.Email = author.Email;
                authorDTO.Name = author.FirstName + " " + author.LastName;

                List<AuthorBookDTO> authorBooks = new List<AuthorBookDTO>();
                AuthorBookDTO authorBookDTO = new AuthorBookDTO();

                foreach (var b in author.Books)
                {
                    authorBookDTO.Title = b.Title;
                    authorBooks.Add(authorBookDTO);
                }
                authorDTO.Books = authorBooks;
                return TypedResults.Ok(authorDTO);


            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }


    }
        
    
}
