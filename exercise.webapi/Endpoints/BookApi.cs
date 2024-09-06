using exercise.webapi.DTOs;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.webapi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            
            app.MapGet("/books", GetBooks);
            app.MapGet("/books/{id}", GetBook);
            app.MapPost("/books", Add);
            app.MapPut("/books{id}", Update);
            app.MapDelete("/books{id}", Delete);
            app.MapPut("/books/addauthor/{id}", AddAuthor);
            app.MapPut("/books/removeauthor/{id}", RemoveAuthor);


        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            try
            {
                var results = await bookRepository.GetAllBooks();
                List<BookDTO> bookDTOs = new List<BookDTO>();

                foreach (var b in results)
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
                return TypedResults.NoContent();
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            try
            {
                var b = await bookRepository.GetBook(id);
                if (b == null)
                {
                    return TypedResults.Problem("thats crazy bro doesnt exist"); 
                }
                BookDTO book = new BookDTO();
                book.Title = b.Title;
                BookAuthorDTO author = new BookAuthorDTO();
                if (b.Author != null)
                {
                    author.Name = b.Author.FirstName + " " + b.Author.LastName;
                    book.Author = author;
                }
      
                return TypedResults.Ok(book);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]

        private static async Task<IResult> Add(IBookRepository bookRepository, IAuthorRepository authorRepository, BookPostModel book)
        {
            
            try
            {
                BookDTO bookDTO = new BookDTO();
                BookAuthorDTO authorDTO = new BookAuthorDTO();

                
                var authorTarget = await authorRepository.GetAuthor(book.AuthorID);
                if (authorTarget == null)
                {
                    return TypedResults.NotFound();
                }
                
               
                var result = await bookRepository.CreateBook(new Book() { Title = book.Title, AuthorId = book.AuthorID, Author = await authorRepository.GetAuthor(book.AuthorID)});
                Book nb = await bookRepository.GetBook(result.Id);

                bookDTO.Title = nb.Title;
                authorDTO.Name = nb.Author.FirstName + " " + nb.Author.LastName;
                bookDTO.Author = authorDTO;
                return TypedResults.Ok(bookDTO);


            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
            
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        private static async Task<IResult> Delete(IBookRepository bookRepository, int id)
        {
            try
            {
                await bookRepository.DeleteBook(id);
                return TypedResults.Ok("Deleted");
            }
            catch(Exception ex) 
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
         
        private static async Task<IResult> Update(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookId, int authorId)
        {
            try
            {
                Book targetBook = await bookRepository.GetBook(bookId);
                if (targetBook == null)
                {
                    return TypedResults.NotFound("Book not found");
                }

                Author newAuthor = await authorRepository.GetAuthor(authorId);
                if (newAuthor == null)
                {
                    return TypedResults.NotFound("Author not found");
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

        private static async Task<IResult> AddAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int bookId, int authorId)
        {
            try
            {
                Book targetBook = await bookRepository.GetBook(bookId);
                if (targetBook == null)
                {
                    return TypedResults.NotFound("Book not found");
                }

                Author newAuthor = await authorRepository.GetAuthor(authorId);
                if (newAuthor == null)
                {
                    return TypedResults.NotFound("Author not found");
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

        private static async Task<IResult> RemoveAuthor(IBookRepository bookRepository, IAuthorRepository authorRepository, int id)
        {
            try
            {
                Book b = await bookRepository.GetBook(id);
                Author ripAuthor = await authorRepository.GetAuthor(b.AuthorId);
                b = await bookRepository.RemoveAuthor(id);
                ripAuthor.Books.Remove(b);
                

                return TypedResults.Ok(b);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

    }
}
