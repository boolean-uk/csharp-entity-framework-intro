using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {

        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("/authors");
            authors.MapGet("", GetAuthors);
            authors.MapGet("/{id}", GetAnAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            try
            {
                var result = await authorRepository.GetAuthors();

                List<AuthorDTO> authorDTOs = new List<AuthorDTO>();

                foreach (var a in result)
                {
                    AuthorDTO authorResponseDTO = new AuthorDTO();
                    authorResponseDTO.Name = a.FirstName + " " + a.LastName;    
                    authorResponseDTO.Email = a.Email;  
                    authorResponseDTO.Books = new List<AuthorBookDTO>();

                    foreach (var b in a.Books) 
                    {
                        AuthorBookDTO authorBookDTO = new AuthorBookDTO();
                        authorBookDTO.Title = b.Title;
                        authorResponseDTO.Books.Add(authorBookDTO);
                    }
                    
                    authorDTOs.Add(authorResponseDTO);
                }

                return TypedResults.Ok(authorDTOs);
            }
            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);
            }
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAnAuthor(IAuthorRepository authorRepository, int id)
        {
            try
            {
                var author = await authorRepository.GetAnAuthor(id);

                AuthorDTO authorDTO = new AuthorDTO();
                authorDTO.Name = author.FirstName + " " + author.LastName;
                authorDTO.Email = author.Email;

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
            catch (Exception)
            {
                return TypedResults.NotFound("Author not found!");
                
            }
        }
        
    }
}
