using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/{id}", GetBook);
            app.MapDelete("/{id}", DeleteBook);
            app.MapPost("/", CreateBook);
            app.MapPut("/{bookid}/{newauthorid}", UpdateBook);


        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            List<BookDTO> bookdtos = new List<BookDTO>();
            var books = await bookRepository.GetAllBooks();

            foreach (var book in books)
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Id = book.Id;
                bookDTO.Title = book.Title;
                bookDTO.AuthorId = book.AuthorId;
                bookDTO.AuthorName = book.Author.FirstName;
                bookdtos.Add(bookDTO);
            }
            return TypedResults.Ok(bookdtos);
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookrepository, int id)
        {
            var book = await bookrepository.GetBook(id);

            if (book == null)
            {
                return TypedResults.NotFound();
            }

            BookDTO bookDTo = new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                AuthorName = book.Author.FirstName
                
            };
            return TypedResults.Ok(bookDTo);
        }
        
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);

            if (book == null)
            {
                return TypedResults.NotFound("Book was not found");
            }
            BookDTO bookDTO = new BookDTO()
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                AuthorName = book.Author.FirstName,
            };
            bookRepository.DeleteBook(id);

            return TypedResults.Ok(bookDTO);

        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository repository, BookPostModel model)
        {
            var result = await repository.GetAllAuthors();

            if (!result.Any(a => a.Id == model.AuthorId))
            {
                return TypedResults.NotFound();
            }

            Book book = new Book();

            book.Title = model.Title;
            book.AuthorId = model.AuthorId;

            await bookRepository.AddBook(book);

            return TypedResults.Ok(model);
        }
        private static async Task<IResult> UpdateBook(IBookRepository bookrepository, IAuthorRepository authorRepository, int bookid, int newauthorid)
        {
            var result = await authorRepository.GetAllAuthors();

            if (!result.Any(a => a.Id == newauthorid))
            {
                return TypedResults.NotFound();
            }

            var entity = await bookrepository.UpdateBookById(bookid, newauthorid);

            return TypedResults.Ok(new { Title = entity.Title, entity.Author.FirstName });

            

        }


            
        
            
        }

    }

