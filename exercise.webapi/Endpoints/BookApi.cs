using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBooksApi(this WebApplication app)
        {
            app.MapGet("/books", GetBooks);
            app.MapGet("/book", GetBook);
            app.MapPut("/updateBook", UpdateBook);
            app.MapDelete("/deleteBook", DeleteBook);
            app.MapPost("/CreateBook", CreateBook);


        }

        private static async Task<IResult> CreateBook(IBookRepository bookRepository, string title,int id)
        {
           Book book =  await bookRepository.CreateBook(title ,id);  
            BookDTO bookDTO = new BookDTO();

            if (book == null) {

                return TypedResults.NotFound(new { Message = $"author with ID {id} not found." });
            }


            bookDTO.Title = book.Title;
            bookDTO.AuthorName = $"{book.Author.FirstName} {book.Author.LastName}";

            return TypedResults.Ok(bookDTO);





        }

        private static async Task<IResult> DeleteBook(IBookRepository bookRepository, int id)
        {
            bool check=  await bookRepository.DeleteBook(id);
            if (!check) {

                return TypedResults.NotFound(new { Message = $"Book with ID {id} not found." });

            }
            return TypedResults.Ok(new { Message = $"Book with ID {id} was succesfully removed!."});


        }

        private static async Task<IResult> GetBooks(IBookRepository bookRepository)
        {
            var books = await bookRepository.GetAllBooks();
            var bookDtos = books.Select(b => new BookDTO
            {
                Id = b.Id,
                Title = b.Title,
                AuthorName = $"{b.Author.FirstName} {b.Author.LastName}"
            });

            return TypedResults.Ok(bookDtos);
        }

        private static async Task<IResult> GetBook(IBookRepository bookRepository, int id)
        {
            var book = await bookRepository.GetBook(id);
            if (book == null)
            {
                return TypedResults.NotFound(new { Message = $"Book with ID {id} not found." });
            }
            BookDTO bookDTO = new BookDTO();
            bookDTO.Id = id;
            bookDTO.Title = book.Title;
            bookDTO.AuthorName = $"{book.Author.FirstName} {book.Author.LastName}";


            return TypedResults.Ok(bookDTO);
        }
        
        public static async Task<IResult> UpdateBook(IBookRepository bookRepository, int id, string firstname, string lastname)
        {
            Book book = await bookRepository.UpdateBook(id,firstname,lastname);
            if (book == null)
            {
                return TypedResults.NotFound(new { Message = $"Book with ID {id} not found." });
            }
            BookDTO bookDTO = new BookDTO();
            bookDTO.Id = book.Id;
            bookDTO.Title = book.Title;
            bookDTO.AuthorName = $"{book.Author.FirstName} {book.Author.LastName}";

            return TypedResults.Ok(bookDTO);




        }




    }
}
