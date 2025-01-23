using exercise.webapi.DTO;
using exercise.webapi.Mapper;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorEndpoint(this WebApplication app)
        {
            var pets = app.MapGroup("authors");

            pets.MapGet("/getId{id}", GetAuthor);
            pets.MapGet("/getAll", GetAllAuthors);

        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAllAuthors(IRepository repository)
        {
            var students = await repository.GetAllAuthor();
            var booksDTO = students.Select(s => s.ToAuthorDto());
            return Results.Ok(booksDTO); 
        }


        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> GetAuthor(IRepository repository, [FromQuery] int id)
        {
            var author = await repository.GetAuthor(id);
            if (author == null)
            {
                return Results.NotFound("No Authors of the provided Id were found.");
            }

            var productDTO = new AuthorListDTO
            {
                Id = author.Id,
                FirstName = author.FirstName,
                LastName = author.LastName,
                Email = author.Email,
                Books = author.Books?.Select(s => new BookListDTO
                {
                    Id = s.Id,
                    Title = s.Title,
                    //ProfileId = s.ProfileId
                }).ToList()
            };


            return Results.Ok(productDTO);
        }


        //[ProducesResponseType(StatusCodes.Status201Created)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //public static async Task<IResult> AddBook(IRepository repository, AddBookDTO model)
        //{
        //    try
        //    {

        //        Book book = new Book()
        //        {
        //            Title = model.Title,
        //            AuthorId = model.AuthorId
        //        };
        //        await repository.CreateAsync(book);

        //        return TypedResults.Created($"https://localhost:7010/books/{book.Id}", book);


        //    }
        //    catch (Exception ex)
        //    {
        //        return TypedResults.Problem(ex.Message);
        //    }
        //}
        ////public static async Task<IResult> Create(IRepository repository, [FromBody] AddBookDTO bookDto)
        ////{
        ////    var model = bookDto.ToSkillFromCreateDto();
        ////    await repository.CreateAsync(model);

        ////    return Results.CreatedAtRoute(nameof(GetBook), new { id = model.Id }, model.ToSkillDto());

        ////}
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public static async Task<IResult> DeleteBook(IRepository repository, int id)
        //{
        //    try
        //    {
        //        var deletedBook = await repository.DeleteAsync(id);
        //        if (deletedBook != null) return Results.Ok(new { When = DateTime.Now, Status = "Deleted", deletedBook.Title });
        //        return TypedResults.NotFound();
        //    }
        //    catch (Exception ex)
        //    {
        //        return TypedResults.Problem(ex.Message);
        //    }
        //}
        //[ProducesResponseType(StatusCodes.Status200OK)]
        //[ProducesResponseType(StatusCodes.Status400BadRequest)]
        //[ProducesResponseType(StatusCodes.Status404NotFound)]
        //public static async Task<IResult> UpdateBook(IRepository repository, int id, AddBookDTO model)
        //{
        //    try
        //    {
        //        var target = await repository.GetBook(id);
        //        if (target == null) return Results.NotFound("Product not found");
        //        if (model.Title != null) target.Title = model.Title; else return Results.BadRequest("error");
        //        await repository.UpdateBook(target);
        //        return Results.Ok(target);
        //    }
        //    catch (Exception ex)
        //    {
        //        return TypedResults.Problem(ex.Message);
        //    }
        //}

    }
}
