using static exercise.webapi.Repository.IAuthorRepository;
using exercise.webapi.DTOs;
using exercise.webapi.Repository;
using exercise.webapi.Models;
using Microsoft.AspNetCore.Mvc;
using static exercise.webapi.DTOs.payloads;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            var authors = app.MapGroup("authors");
            authors.MapGet("/", GetAuthors);
            authors.MapGet("/{Id}", GetAnAuthor);
            authors.MapPut("/{Id}/author/", UpdateAuthor);
            authors.MapDelete("/{Id}", DeleteAuthor);
            authors.MapPost("/{Id}", CreateAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            var authors = await repository.GetAuthors();
            var authorDto = new List<AuthorResponseDTO>();
            foreach (Author author in authors)
            {
                authorDto.Add(new AuthorResponseDTO(author));
            }
            return TypedResults.Ok(authorDto);
        }


        private static async Task<IResult> GetAnAuthor(int authorId, IAuthorRepository repository)
        {
            var author = await repository.GetAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound("Author not found");
            }

            return TypedResults.Ok(new AuthorResponseDTO(author));

        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateAuthor(int authorId, UpdateAuthorPayload payload, IAuthorRepository repository)
        {
            Author? author = await repository.GetAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound("Author was not found");
            }
            Author? authorUpdated = await repository.UpdateAuthor(authorId, payload.newFirstName, payload.newLastName, payload.newEmail);
            if (authorUpdated == null)
            {
                return Results.BadRequest("Failed to update author.");
            }
            return TypedResults.Ok(new AuthorResponseDTO(author));
        }

        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> DeleteAuthor(int authorId, IAuthorRepository repository)
        {
            Author? author = await repository.GetAuthor(authorId);
            if (author == null)
            {
                return TypedResults.NotFound("Author not found");
            }
            Author? authorDelete = await repository.DeleteAuthor(authorId);
            if (authorDelete == null)
            {
                return Results.BadRequest("Failed to delete author.");
            }

            return TypedResults.Ok(new AuthorResponseDTO(author));
        }


        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> CreateAuthor(CreateAuthorPayload payload, IAuthorRepository repository)
        {
            if (payload.FirstName == null || payload.LastName == ""||payload.Email == "")
            {
                return Results.BadRequest("A non-empty Name is required");
            }

            Author? author = await repository.CreateAuthor(payload.FirstName, payload.LastName, payload.Email);
            if (author == null)
            {
                return Results.BadRequest("Failed to create book.");
            }

            return TypedResults.Created($"/author/{author.Id}", new AuthorResponseDTO(author));
        }

    }
}



  

