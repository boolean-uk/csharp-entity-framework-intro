using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authorGroup = app.MapGroup("author");
            authorGroup.MapGet("/", GetAuthors);
            authorGroup.MapGet("/{id}", GetAnAuthor);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            try
            {
                //Source
                var orginal = await authorRepository.GetAuthors();
                //Target:
                List<AuthorDTO2> result = new List<AuthorDTO2>();
                //Transferring:
                foreach (Author entity in orginal)
                {
                    AuthorDTO2 authorDTO = new AuthorDTO2()
                    {
                        Email = entity.Email,
                        FirstName = entity.FirstName,
                        LastName = entity.LastName,


                    };
                        foreach(Book b in entity.Books)
                    {
                        BookDTO3 bookdto = new BookDTO3() { Id = b.Id, Title = b.Title };
                        authorDTO.Books.Add(bookdto);
                    }    


                    result.Add(authorDTO);

                }
                return TypedResults.Ok(result);
            }

            catch (Exception ex) { return TypedResults.BadRequest("invalid"); }

        }



        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetAnAuthor(IAuthorRepository authorRepository, int? id)
        {
            try
            {
                //Source:
                var original = await authorRepository.GetAnAuthors(id);
                //Target and transferring:
                AuthorDTO2 result = new AuthorDTO2()
                {
                    
                    Email = original.Email,
                    FirstName = original.FirstName,
                    LastName = original.LastName,
                    Books = original.Books.Select(book => new BookDTO3 {Title = book.Title, Id = book.Id}).ToList()         // THIS IS IMPOIRTANT!!! NEED TO TRANSFER!
                };

                return TypedResults.Ok(result);


            }

            catch (BadHttpRequestException ex) { return TypedResults.BadRequest(ex.Message); }
            catch (Exception ex) { return TypedResults.NotFound(ex.Message); }

        }



    }
}
