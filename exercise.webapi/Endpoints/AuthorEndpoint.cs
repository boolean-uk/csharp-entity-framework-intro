﻿using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Win32;
using System.Net;

namespace exercise.webapi.Endpoints
{
    public static class AuthorEndpoint
    {
        public static void ConfigureAuthorEndpoints(this WebApplication app)
        {
            var authors = app.MapGroup("authors");

            authors.MapGet("/authors", GetAuthors);
            authors.MapGet("/{id}", GetAAuthor);
            authors.MapPut("/{id}", UpdateAuthor);
            authors.MapDelete("/{id}", DeleteAuthor);
            authors.MapPost("/", AddAAuthor);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> GetAuthors(IAuthorRepository repository)
        {
            //custom DTO
            GetAuthorsResponse response = new GetAuthorsResponse();

            var results = await repository.GetAllAuthors();

            foreach (Author a in results)
            {
                AuthorEndpointResponseAuthor responseAuthor = MakeResponseAuthorDTO(a);

                response.Authors.Add(responseAuthor);
            }

            return TypedResults.Ok(response);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public static async Task<IResult> GetAAuthor(IAuthorRepository repository, int id)
        {
            try
            {
                var target = await repository.GetById(id);
                if (target is null)
                {
                    return TypedResults.NotFound("Author Not Found");
                }

                AuthorEndpointResponseAuthor responseAuthor = MakeResponseAuthorDTO(target);

                return TypedResults.Ok(responseAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.ToString());
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> UpdateAuthor(IAuthorRepository repository, IAuthorBookRepository authorBookRepository, int id, AuthorPutModel model)
        {
            try
            {
                var target = await repository.GetById(id);
                if (target is null)
                {
                    return TypedResults.NotFound("Author Not Found");
                }

                var authorBooks = await authorBookRepository.GetAuthorBooksByAuthorId(id);

                // Remove books
                foreach (AuthorBook authorBook in authorBooks)
                {
                    if (!model.BookIds.Contains(authorBook.BookId))
                    {
                        await authorBookRepository.DeleteById(authorBook.BookId, id);
                    }
                }

                // Add books
                foreach (int bookID in model.BookIds)
                {
                    if (!authorBooks.Select(r => r.BookId).Contains(bookID))
                    {
                        await authorBookRepository.Add(new AuthorBook() { BookId = bookID, AuthorId=id });
                    }
                }

                var updatedTarget = await repository.UpdateById(id, new Author() { FirstName = model.FirstName, LastName = model.LastName, Email = model.Email });

                // Custom DTO
                AuthorEndpointResponseAuthor responseAuthor = MakeResponseAuthorDTO(updatedTarget);
                return TypedResults.Ok(responseAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest($"Invalid Author object - {ex}");
            }
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        public static async Task<IResult> DeleteAuthor(IAuthorRepository authorRepository, IAuthorBookRepository authorBookRepository, int id)
        {
            try
            {
                var target = await authorRepository.DeleteById(id);
                if (target is null)
                {
                    return TypedResults.NotFound("Author Not Found");
                }

                // Deleting relations between the deleted book and authors
                var authorBooks = await authorBookRepository.GetAuthorBooksByAuthorId(id);
                authorBooks.ToList().ForEach(async ab => await authorBookRepository.DeleteById(ab.BookId, id));

                //custom DTO
                AuthorEndpointResponseAuthor responseAuthor = MakeResponseAuthorDTO(target);

                return TypedResults.Ok(responseAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.Problem(ex.Message);
            }
        }

        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public static async Task<IResult> AddAAuthor(IAuthorRepository authorRepository, IBookRepository bookRepository, IAuthorBookRepository authorBookRepository, AuthorPostModel model)
        {
            try
            {
                foreach (int bookId in model.BookIds)
                {
                    var bookTarget = await bookRepository.GetById(bookId);
                    if (bookTarget is null)
                    {
                        return TypedResults.NotFound("Book Not Found");
                    }
                }

                var newAuthor = await authorRepository.Add(new Author() { FirstName=model.FirstName, LastName=model.LastName, Email=model.Email });

                // Creating AuthorBook relations between the created author and their books
                foreach (int bookId in model.BookIds)
                {
                    await authorBookRepository.Add(new AuthorBook() { BookId = bookId, AuthorId = newAuthor.Id });
                }

                AuthorEndpointResponseAuthor responseAuthor = MakeResponseAuthorDTO(newAuthor);
                return TypedResults.Created($"https://localhost:7054/authors/{responseAuthor.Id}", responseAuthor);
            }
            catch (Exception ex)
            {
                return TypedResults.BadRequest($"Invalid author object - {ex}");
            }
        }

        public static AuthorEndpointResponseAuthor MakeResponseAuthorDTO(Author author)
        {
            AuthorEndpointResponseAuthor responseAuthor = new AuthorEndpointResponseAuthor();
            responseAuthor.Id = author.Id;
            responseAuthor.FirstName = author.FirstName;
            responseAuthor.LastName = author.LastName;
            responseAuthor.Email = author.Email;

            foreach (Book b in author.Books)
            {
                AuthorEndpointResponseBook responseBook = new AuthorEndpointResponseBook();
                responseBook.Id = b.Id;
                responseBook.Title = b.Title;
                responseAuthor.Books.Add(responseBook);
            }

            return responseAuthor;
        }
    }
}
