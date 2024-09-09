using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            var book = app.MapGroup("books");
            book.MapGet("/", GetBooks);
            book.MapPost("/", CreateBook);
            book.MapGet("/{id}", GetABook);
            book.MapPut("/{id}", UpdateBook);
            book.MapDelete("/{id}", DeleteBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {

            GetBooksResponse response = new GetBooksResponse();
            var results = await bookRepository.GetAllBooks();

            foreach (Book b in results)
            {
                AuthorWithoutEmailBooks author = new AuthorWithoutEmailBooks();
                author.Name = b.Author.FirstName + " " + b.Author.LastName;
                author.Id = b.Author.Id;
              

                BookDTO book = new BookDTO()
                {
                    Id = b.Id,
                    Title = b.Title,
                    AuthorId = b.AuthorId,
                    Author = author,
                };

                response.Books.Add(book);
            }

            return TypedResults.Ok(response.Books);
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetABook(IBookRepository bookRepository, int id)
        {


            var response = await bookRepository.GetBook(id);
            AuthorWithoutEmailBooks author = new AuthorWithoutEmailBooks();
            author.Name = response.Author.FirstName + " " + response.Author.LastName;
            author.Id = response.Author.Id;
            
            BookDTO book = new BookDTO() 
            { 
                Id = response.Id, 
                Title = response.Title, 
                AuthorId = response.AuthorId,
                Author = author,
                
            };

            
            
            return TypedResults.Ok(book);
        
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateBook(IBookRepository bookRepository, BookPostModel model)
        {

            try
            {

                var book = await bookRepository.CreateABook(new Book() { Title = model.Title, AuthorId = model.AuthorId });
                
                var response = await bookRepository.GetBook(book.Id);

                AuthorWithoutEmailBooks author = new AuthorWithoutEmailBooks()
                {
                    Name = response.Author.FirstName + " " + response.Author.LastName,
                    Id = response.Author.Id,
                };

                BookDTO bookDTO = new BookDTO()
                {
                    Id = response.Id,
                    Title = response.Title,
                    AuthorId = response.AuthorId,
                    Author = author,
                    
                };


                return TypedResults.Ok(bookDTO);

            } catch (Exception ex) {
                return TypedResults.Problem(ex.Message);



            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, BookPutModel model)
        {

            try
            {
                var target = await bookRepository.GetBook(id);
                target.AuthorId = model.AuthorId;

                AuthorWithoutEmailBooks author = new AuthorWithoutEmailBooks();
                author.Name = target.Author.FirstName + " " + target.Author.LastName;
                author.Id = target.Author.Id; ;
       


                BookDTO book = new BookDTO()
                {
                    Id = target.Id,
                    Title = target.Title,
                    AuthorId = target.AuthorId,
                    Author = author,

                };
                

                await bookRepository.UpdateById(id, target);



                return TypedResults.Ok(book);

            }
            catch (Exception ex)
            {

                return TypedResults.Problem(ex.Message);
            }

        }


        public static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            try
            {

                var response = await bookRepository.GetBook(id);
                var book = await bookRepository.DeleteBook(id);

                AuthorWithoutEmailBooks authorDTO = new AuthorWithoutEmailBooks();
                authorDTO.Id = response.Author.Id;
                authorDTO.Name = response.Author.FirstName + " " + response.Author.LastName;
            
                BookDTO bookDTO = new BookDTO()
                {
                    Id = response.Id,
                    Title = response.Title,
                    AuthorId = response.AuthorId,
                    Author = authorDTO,
                  
                };


                return TypedResults.Ok(bookDTO);

            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);



            }
        }
    }
}
