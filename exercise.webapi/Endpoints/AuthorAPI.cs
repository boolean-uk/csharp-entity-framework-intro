﻿using exercise.webapi.DTOs;
using exercise.webapi.Repository;

namespace exercise.webapi.Endpoints
{
    public static class AuthorAPI
    {
        public static void ConfigureAuthorsApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors{id}", GetAuthor);
        }

        private static async Task<IResult> GetAuthors(IAuthorRepository authorRepository)
        {
            var authors = await authorRepository.GetAllAuthors();
            return TypedResults.Ok(AuthorResponseDTO.FromRepository(authors));
        }

        private static async Task<IResult> GetAuthor(IAuthorRepository authorRepository, int id)
        {
            var author = await authorRepository.GetAuthor(id);
            if (author == null)
            {
                return TypedResults.NotFound();
            }
            return TypedResults.Ok(new AuthorResponseDTO(author));
        }

    }
}
