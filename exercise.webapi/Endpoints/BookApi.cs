using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/books{id}", GetABook);
            app.MapPut("/books{id}", UpdateBook);
            app.MapDelete("/books{id}", DeleteBook);
            app.MapPost("/books", AddBook);

        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            //Source data:
            var books = await bookRepository.GetAllBooks();
            //Target data:
            var booksDTO = new List<BookDTO>();





            //Transfer:
            foreach (Book book in books)
            {
                booksDTO.Add(new BookDTO()
                {
                    Id = book.Id,
                    Title = book.Title,

                    AuthorDTO = new AuthorDTO()
                    {
                        FirstName = book.Author.FirstName,
                        LastName = book.Author.LastName,
                        Email = book.Author.Email

                    }

                   /* PublisherDTO = new PublisherDTO()
                    {
                        Name = book.Publisher.Name

                    }*/

                }); 
            }
            return TypedResults.Ok(booksDTO);


        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        private static async Task<IResult> GetABook(IBookRepository bookRepository, int? id)    //[FromQuery] & ? make it no required..
        {
            //bookRepository.GetAllBooks().FirstOrDefault(x => x.Id == id)
            // Default --> the input is required...
            if (id == null)
            {
                return TypedResults.BadRequest();
            }
            else
            {
                //Source data:
                var book = await bookRepository.GetABook(id);
                if (book == null)
                {
                    return TypedResults.NotFound(new { message = "No book with the id." });
                }
                else
                {

                    //Target data:
                    BookDTO bookDTO = new BookDTO()
                    {
                        Id = book.Id,
                        Title = book.Title,
                        AuthorDTO = new AuthorDTO()
                        {
                            FirstName = book.Author.FirstName,
                            LastName = book.Author.LastName,
                            Email = book.Author.Email
                        }
                    };
                    return TypedResults.Ok(bookDTO);
                }
            }

        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> UpdateBook(IBookRepository bookRepository, int? id, [FromBody] UpdateAuthorDTO newAuthor)
        {

            /*try
            {
                Book original = await context.GetABook(id);
                original.Name = newProduct.Name;
                original.Price = newProduct.Price;
                original.Category = newProduct.Category;
                await context.Update(id, original);
                return TypedResults.Ok(original);
            }
            catch (ArgumentException ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            ----------------------------------------------------------
            In repo:

             if (await NameExistsInDatabase(newItem.Name))
            {
                throw new ArgumentException($"Product with name '{newItem.Name}' already exists!");
            }
            return await base.Update(id, newItem);
            }*/

            //SourceData:
            var newBook = await bookRepository.UpdateBook(id, newAuthor);
            if (newBook == null)
            {
                return TypedResults.NotFound(new { message = "No book with the id." });
            }
            else
            {
                //Target data:
                BookDTO bookDTO = new BookDTO()
                {
                    Id = newBook.Id,
                    Title = newBook.Title,
                    AuthorDTO = new AuthorDTO()
                    {
                        FirstName = newBook.Author.FirstName,
                        LastName = newBook.Author.LastName,
                        Email = newBook.Author.Email
                    }
                };
                return TypedResults.Created($"/{1}", bookDTO);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int? id)
        {
            try
            {
                // Source:
                Book original = await bookRepository.DeleteBook(id);

                //Target and transfer:
                var result = new BookDTO()
                {
                    Id = original.Id,
                    Title = original.Title,
                    AuthorDTO = new AuthorDTO()
                    {
                        FirstName = original.Author.FirstName,
                        LastName = original.Author.LastName,
                        Email = original.Author.Email
                    }
                };

                return TypedResults.Created($"/{1}", result);

            }
            catch (ArgumentException ex)
            {
                return TypedResults.BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        private static async Task<IResult> AddBook(IBookRepository bookRepository, [FromBody] NewBookDTO newBook)
        {
            if (newBook.AuthorId== null || newBook.Title == null) { return TypedResults.BadRequest("NOT VALID."); }
            try {
                //Source:
                Book original = await bookRepository.AddBook(newBook);
                //Target and transfer:
                BookDTO bookDTO = new BookDTO() {
                    Title = original.Title,
                    Id = original.Id,
                    AuthorDTO = new AuthorDTO()
                    {
                        FirstName = original.Author.FirstName,
                        LastName = original.Author.LastName,
                        Email = original.Author.Email
                    }
                };
                return TypedResults.Created(nameof(AddBook), bookDTO);
            }

           /* catch (ArgumentException ex) { 
                return TypedResults.BadRequest(ex.Message);*/
            //}
            catch ( Exception ex)
            {
                return TypedResults.NotFound(ex.Message);
            }

        }
    }
}

