
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using static System.Reflection.Metadata.BlobBuilder;
namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigueAuthorEnpoints(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IBookRepository bookRepository)
        {
            var authors = new Payload<List<AuthorDTO>>()
            {
                Data = new List<AuthorDTO>()
            };

            var results = await bookRepository.GetAllAuthor();
            var books = await bookRepository.GetAllBooks();
            foreach (Author author in results)
            {
                AuthorDTO authorDTO = new AuthorDTO();
                
                authorDTO.firstname = author.FirstName;
                authorDTO.lastname = author.LastName;
                authorDTO.email = author.Email;
                authorDTO.id = author.Id;
                authorDTO.books = new List<BookDTO>();


                var authorBooks = books.Where(b => b.AuthorId == author.Id).ToList();
                
                foreach(Book book in authorBooks)
                {
                    BookDTO dto = new BookDTO();
                    dto.title = book.Title;
                    dto.author_id = book.AuthorId;
                    dto.id = book.Id;
                    
                    authorDTO.books.Add(dto);
                }

                authors.Data.Add(authorDTO);
            }
            return TypedResults.Ok(authors);
        }
        private static async Task<IResult>GetAuthor(IBookRepository bookRepository, int id)
        {
            var payload = new Payload<AuthorDTO>();

            Author author = await bookRepository.GetAuthor(id);
            var books = await bookRepository.GetAllBooks();
            AuthorDTO authorDTO = new AuthorDTO();
            authorDTO.email = author.Email;
            authorDTO.firstname = author.FirstName;
            authorDTO.lastname = author.LastName;
            authorDTO.id = author.Id;
            authorDTO.books = new List<BookDTO>();
            var authorBooks = books.Where(x => x.AuthorId == author.Id).ToList();
            foreach(Book book in authorBooks)
            {
                BookDTO dto = new BookDTO();
                dto.title = book.Title;
                dto.id = book.Id;
                dto.author_id = book.AuthorId;
                authorDTO.books.Add(dto);
            }

            payload.Data = authorDTO;

            return TypedResults.Ok(payload);

        }
    }
}
