using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    { 
        public static void ConfigureAuthorEndpoints(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{id}", GetAuthor);

        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository rep)
        {
            GetAuthorResponse response = new GetAuthorResponse();
            var authors = await rep.GetAuthors();
           
            foreach (Author a in authors)
            {

                AuthorDTO authorDTO = new AuthorDTO()
                {
                    Id = a.Id,
                    Name = a.FirstName + " " + a.LastName,
                    Email = a.Email,

                };

                foreach (Book b in a.Books )
                {
                    PublisherWithoutBooksDTO publisherDTO = new PublisherWithoutBooksDTO()
                    {
                        Id = b.Publisher.Id,
                        Name = b.Publisher.FirstName + " " + b.Publisher.LastName,

                    };
                    BookWithoutAuthor bookDTO = new BookWithoutAuthor() { 
                        Title = b.Title, 
                        Id = b.Id,
                        Publisher = publisherDTO
                    };

                    authorDTO.Books.Add(bookDTO);
                }

               

                response.authors.Add(authorDTO);
            }
            
            
            
            return TypedResults.Ok(response);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthor(IAuthorRepository rep, int id)
        {
            var author = await rep.GetAnAuthor(id);
            AuthorDTO authorDTO = new AuthorDTO();
            
            authorDTO.Id = id;
            authorDTO.Name = author.FirstName + " " + author.LastName;
            authorDTO.Email = author.Email;



            foreach (Book b in author.Books)
            {

                PublisherWithoutBooksDTO publisherDTO = new PublisherWithoutBooksDTO()
                {
                    Id = b.Publisher.Id,
                    Name = b.Publisher.FirstName + " " + b.Publisher.LastName,

                };
                BookWithoutAuthor bookDTO = new BookWithoutAuthor()
                {
                    Title = b.Title,
                    Id = b.Id,
                    Publisher = publisherDTO

                };
                authorDTO.Books.Add(bookDTO);

            }
                return TypedResults.Ok(authorDTO);

        }



    }
}
