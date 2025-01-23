using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Components.Authorization;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("books/{id}", GetSingleBook);
            app.MapPost("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPost("/books", CreateBook);
        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = new Payload<List<BookDTO>>()
            {
                Data = new List<BookDTO>()
            };

            var results = await bookRepository.GetAllBooks();
            foreach (Book book in results)
            {

                BookDTO bookDTO = new BookDTO();

                //author
                AuthorDTOnoBooks authorDTO = new AuthorDTOnoBooks();
                authorDTO.FirstName = book.Author.FirstName;
                authorDTO.LastName = book.Author.LastName;
                authorDTO.Email = book.Author.Email;
                authorDTO.id = book.Author.Id;

                //publisher
                PublisherNoBooks publisherDTO = new PublisherNoBooks();
                publisherDTO.FirstName = book.Publisher.FirstName;
                publisherDTO.LastName = book.Publisher.LastName;
                publisherDTO.Id = book.Publisher.Id;

                


                //bookDTO
                bookDTO.title = book.Title;
                bookDTO.id = book.Id;
                
                bookDTO.author = authorDTO;
                
                bookDTO.publisher = publisherDTO;
                
                books.Data.Add(bookDTO);

            }
            return TypedResults.Ok(books);
        }

        private static async Task<IResult> GetSingleBook(IBookRepository bookRepository, int id)
        {
            var book = new Payload<BookDTO>();

            Book result = await bookRepository.GetBook(id);

            BookDTO bookDTO = new BookDTO();

            //author
            AuthorDTOnoBooks authorDTO = new AuthorDTOnoBooks();
            bookDTO.title = result.Title;
            bookDTO.id = result.Id;
            
            authorDTO.FirstName = result.Author.FirstName;
            authorDTO.LastName = result.Author.LastName;
            authorDTO.Email = result.Author.Email;
            authorDTO.id = result.Author.Id;

            //publisher

            PublisherNoBooks publisherDTO = new PublisherNoBooks();
            publisherDTO.FirstName = result.Publisher.FirstName;
            publisherDTO.LastName = result.Publisher.LastName;
            publisherDTO.Id = result.Publisher.Id;
            bookDTO.publisher = publisherDTO;
            bookDTO.author = authorDTO;
            book.Data = bookDTO;
            return TypedResults.Ok(book);

        }

        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, int author_id)
        {
            var booker = new Payload<BookDTO>();
            Book book = await bookRepository.UpdateBook(id, author_id);

            BookDTO bookDTO = new BookDTO();
            AuthorDTOnoBooks authorDTO = new AuthorDTOnoBooks();
            bookDTO.title = book.Title;
            bookDTO.id = book.Id;
            
            //author
            authorDTO.FirstName = book.Author.FirstName;
            authorDTO.LastName = book.Author.LastName;
            authorDTO.Email = book.Author.Email;
            authorDTO.id = book.Author.Id;

            //publisher
            PublisherNoBooks publisherDTO = new PublisherNoBooks();
            publisherDTO.FirstName = book.Publisher.FirstName;
            publisherDTO.LastName = book.Publisher.LastName;
            publisherDTO.Id = book.Publisher.Id;

            bookDTO.publisher = publisherDTO;
            bookDTO.author = authorDTO;
            booker.Data = bookDTO;
            return TypedResults.Ok(booker);


        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            Book bookToDelete = await bookRepository.GetBook(id);

            BookDTO bookDTO = new BookDTO();

            bookDTO.id = bookToDelete.Id;
            bookDTO.title = bookToDelete.Title;
           
            //author
            AuthorDTOnoBooks authorDTO = new AuthorDTOnoBooks();
            authorDTO.FirstName = bookToDelete.Author.FirstName;
            authorDTO.LastName = bookToDelete.Author.LastName;
            authorDTO.id = bookToDelete.Author.Id;
            authorDTO.Email = bookToDelete.Author.Email;

            //publisher
            PublisherNoBooks publisherDTO = new PublisherNoBooks();
            publisherDTO.FirstName = bookToDelete.Publisher.FirstName;
            publisherDTO.LastName = bookToDelete.Publisher.LastName;
            publisherDTO.Id = bookToDelete.Publisher.Id;

            bookDTO.publisher = publisherDTO;
            bookDTO.author = authorDTO;
            
            await bookRepository.DeleteBook(id);

            return TypedResults.Ok(bookDTO);
        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, string title, int author_id, int publisher_id)
        {
            Book book = await bookRepository.CreateBook(title, author_id, publisher_id);
            Payload<BookDTO>payload = new Payload<BookDTO>();
            BookDTO bookDTO = new BookDTO();

            bookDTO.id = book.Id;
            bookDTO.title = book.Title;
            
            AuthorDTOnoBooks authorDTO = new AuthorDTOnoBooks();
            authorDTO.FirstName = book.Author.FirstName;
            authorDTO.LastName = book.Author.LastName;
            authorDTO.id = book.Author.Id;
            authorDTO.Email = book.Author.Email;

            PublisherNoBooks publisherDTO = new PublisherNoBooks();
            publisherDTO.FirstName = book.Publisher.FirstName;
            publisherDTO.LastName = book.Publisher.LastName;
            publisherDTO.Id = book.Publisher.Id;

            bookDTO.publisher = publisherDTO;
            bookDTO.author = authorDTO;
            payload.Data = bookDTO;
            return TypedResults.Ok(payload);

        }

        
    }
}