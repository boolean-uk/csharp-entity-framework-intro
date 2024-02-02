using exercise.webapi.Models;
using exercise.webapi.Models.DTO;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {

        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/GetAuthors", GetAuthors);
            app.MapGet("/GetAuthors{id}", GetAuthorById);
        }





        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            //Get authors method to get original authors
            var authors = await authorRepository.GetAuthors();
            
            //instantiate a new list of the author DTO
            var authorDto = new List<AuthorDto2>();


            //add the authors in the DTO
            foreach (var author in authors)
            {
              
                AuthorDto2 authordto = new AuthorDto2()
                {
                    Id = author.Id,
                    firstName = author.FirstName,
                    lastName = author.LastName,
                    email = author.Email,
                    
                 

                };
                foreach (var book in author.Books)
                {
                    GetBookDtoNoAuthor bookDto = new GetBookDtoNoAuthor()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Publisher = new PublisherForBookDto
                        {
                            Id = book.Publisher.Id,
                            Name = book.Publisher.Name
                        }
                    };
                    //add books without author value Dto avoid cylical reference

                    authordto.books.Add(bookDto);
                    
                }
                authorDto.Add(authordto);
            }
            
            return TypedResults.Ok(authorDto);
        }
     

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthorById(int id, IAuthorRepository authorRepository)
        {
            //Get author by id
            var Author = await authorRepository.GetAuthorById(id);

            //package author in a DTO
            GetAuthorDto authorDto = new GetAuthorDto()
            {
                firstName = Author.FirstName, lastName = Author.LastName, Id = Author.Id, email = Author.Email
            };

            //Find books from origimal Author nad add it to the Author DTO
            foreach (var book in Author.Books)
            {
                GetBookDtoNoAuthor bookDto = new GetBookDtoNoAuthor()
                {
                    Id = book.Id,
                    Title = book.Title,
                     Publisher = new PublisherForBookDto
                     {
                         Id = book.Publisher.Id,
                         Name = book.Publisher.Name
                     }
                };
                authorDto.books.Add(bookDto);
            }

            return TypedResults.Ok(authorDto);
        }
    }
}