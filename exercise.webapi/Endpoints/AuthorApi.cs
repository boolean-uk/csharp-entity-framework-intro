using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors{id}", GetAuthor);
            app.MapGet("/authors/", GetAuthors);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthor(IAuthorRepository repo, int id)
        {
            var auth = await repo.GetAuthorById(id);
            List<Object> books = new List<Object>();

            foreach (var item in auth.Books)
            { 
                books.Add(item);
            }

            //return custom object
            return TypedResults.Ok(new { 
                Id = auth.Id, 
                FirstName = auth.FirstName,
                LastName = auth.LastName, 
                Email = auth.Email,
                books = books
            });
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetAuthors(IAuthorRepository Authrepo, IBookRepository bookRepo)
        {
            var authors = await Authrepo.GetAuthors();
            List<Object> anonAuthorList= new List<Object>();


            foreach (Author auth in authors) 
            {
                auth.Books = bookRepo.GetAllBooks().Result.Where(a => a.AuthorId == auth.Id).ToList();

                List<string> books = new List<string>(); 

                foreach (Book book in auth.Books)
                {
                    books.Add(book.Title + " published by " + book.Publisher.Name);
                }

                anonAuthorList.Add(new
                {
                    Id = auth.Id,
                    FirstName = auth.FirstName,
                    LastName = auth.LastName,
                    Email = auth.Email,
                    books = books
                });
            }

            return TypedResults.Ok(anonAuthorList);
        }
    }
}
