using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Expressions;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetABook);
            app.MapPost("/books", CreateBook);
            app.MapPut("/books/{id}", UpdateBook);
            app.MapDelete("/books/{id}", DeleteBook);
            app.MapPut("/books/removeauthor/{id}", RemoveAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> RemoveAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int id)
        {
            try
            {
                Book targetBook = await bookRepository.GetBook(id);

                Author author = await authorRepository.GetAnAuthor(targetBook.AuthorId);

                author.Books.Remove(targetBook);  
                targetBook = await bookRepository.RemoveAuthor(id);

                BookDTO bookDTO = new BookDTO();

                
                bookDTO.Title = targetBook.Title;

              //  BookAuthorDTO bookAuthorDTO = new BookAuthorDTO();

                //bookAuthorDTO.Name = book.Author.FirstName + " " + book.Author.LastName;
                // bookDTO.Author = bookAuthorDTO;


                return TypedResults.Ok(bookDTO);

            }
            catch (Exception ex)
            {
                return TypedResults.NotFound("Book not found!");
            }

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            try
            {

                var books = await bookRepository.GetAllBooks();

                List<BookDTO> bookDTOs = new List<BookDTO>();

                foreach (var b in books)
                {
                    BookDTO book = new BookDTO();
                    book.Title = b.Title;
                    
                    BookAuthorDTO author = new BookAuthorDTO();
                    author.Name = b.Author.FirstName + " " + b.Author.LastName;

                    book.Author = author;

                    bookDTOs.Add(book);
                }
                
                return TypedResults.Ok(bookDTOs);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> GetABook(IBookRepository bookRepositry, int id)
        {
            try
            {
                var book = await bookRepositry.GetBook(id);

                
                BookDTO bookDTO = new BookDTO();
                bookDTO.Title = book.Title;
                
                BookAuthorDTO authorDTO = new BookAuthorDTO();
                if (book.Author != null)
                {
                    authorDTO.Name = book.Author.FirstName + " " + book.Author.LastName;

                    bookDTO.Author = authorDTO;
                }

                return TypedResults.Ok(bookDTO);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> CreateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostModel newBook)
        {
            try
            {
                BookDTO bookDTO = new BookDTO();
                BookAuthorDTO authorDTO = new BookAuthorDTO();

                
                var authorTarget = await authorRepository.GetAnAuthor(newBook.AuthorId);

                if (authorTarget == null) 
                {
                    return TypedResults.NotFound("Author not found");
                }

                var result = await bookRepository.CreateBook(new Book() { Title = newBook.Title, AuthorId = newBook.AuthorId });
                
                Book nb = await bookRepository.GetBook(result.Id);
                
                bookDTO.Title = nb.Title;
                authorDTO.Name = nb.Author.FirstName + " " + nb.Author.LastName;    
                bookDTO.Author = authorDTO;

                return TypedResults.Ok(bookDTO); 
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookId, int authorId)
        {
            try
            {
                Book targetBook = await bookRepository.GetBook(bookId);

                if (targetBook == null)
                {
                    return TypedResults.NotFound("Book not found!");
                }

                Author newAuthor = await authorRepository.GetAnAuthor(authorId);

                if (newAuthor == null)
                {
                    return TypedResults.NotFound("Author not found!");
                }

                var result = await bookRepository.UpdateBook(bookId, newAuthor);
            

                BookDTO bookDTO = new BookDTO();
                BookAuthorDTO authorDTO = new BookAuthorDTO();

                bookDTO.Title = result.Title;

                authorDTO.Name = result.Author.FirstName + " " + result.Author.LastName;
                bookDTO.Author = authorDTO;

                return TypedResults.Ok(bookDTO);

            }
            catch (Exception ex)
            {

                return TypedResults.BadRequest(ex.Message);
            }
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            try
            {
                await bookRepository.DeleteBook(id);

                return TypedResults.Ok("Deleted");
            } 
            catch (Exception ex) 
            {
                return TypedResults.NotFound(ex.Message); 
            }

        }

    }
}
