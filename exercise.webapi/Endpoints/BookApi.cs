using exercise.webapi.DTO;
using exercise.webapi.Mapper;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class BookApi
    {
        public static void ConfigureBookEndpoint(this WebApplication app)
        {
            var pets = app.MapGroup("books");

            pets.MapGet("/getId{id}", GetBook);
            pets.MapGet("/getAll", GetAllBooks);
            pets.MapPost("/add", AddBook);
            pets.MapDelete("/{id}", DeleteBook);
            pets.MapPut("/{id}", UpdateBook);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllBooks(IRepository repository)
        {
            var students = await repository.GetAllBooks();
            var booksDTO = students.Select(s => s.ToBookDto());
            return Results.Ok(booksDTO); 
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetBook(IRepository repository, [FromQuery] int id)
        {
            var book = await repository.GetBook(id);
            if (book == null)
            {
                return Results.NotFound("No Books of the provided Id were found.");
            }

            var productDTO = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                }
            };


            return Results.Ok(productDTO);
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddBook(IRepository repository, AddBookDTO model)
        {
            try
            {
                Book book = new Book()
                {
                    Title = model.Title,
                    AuthorId = model.AuthorId
                };
                await repository.CreateAsync(book);

                return TypedResults.Created($"https://localhost:7010/books/{book.Id}", book);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        //public static async Task<IResult> Create(IRepository repository, [FromBody] AddBookDTO bookDto)
        //{
        //    var model = bookDto.ToSkillFromCreateDto();
        //    await repository.CreateAsync(model);

        //    return Results.CreatedAtRoute(nameof(GetBook), new { id = model.Id }, model.ToSkillDto());

        //}
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> DeleteBook(IRepository repository, int id)
        {
            try
            {
                var deletedBook = await repository.DeleteAsync(id);
                if (deletedBook != null) return Results.Ok(new { When = DateTime.Now, Status = "Deleted", deletedBook.Title });
                return TypedResults.NotFound();
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> UpdateBook(IRepository repository, int id, AddBookDTO model)
        {
            try
            {
                var target = await repository.GetBook(id);
                if (target == null) return Results.NotFound("Product not found");
                if (model.Title != null) target.Title = model.Title; else return Results.BadRequest("error");
                await repository.UpdateBook(target);
                return Results.Ok(target);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

    }
}
