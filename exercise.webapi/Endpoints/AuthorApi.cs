using AutoMapper;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using static System.Reflection.Metadata.BlobBuilder;

namespace exercise.webapi.Endpoints
{
    public static class AuthorApi
    {
        public static void ConfigureAuthorApi(this WebApplication app)
        {
            app.MapGet("/authors", GetAuthors);
            app.MapGet("/authors/{id}", GetAuthor);
            
        }

        private static async Task<IResult> GetAuthors(IRepository<Author> repository, IRepository<Book> bookRepository, IMapper mapper)
        {
            try
            {
                var authors = await repository.GetAll();
                List<AuthorResponseDto> response = new List<AuthorResponseDto>();

                foreach (var author in authors) 
                {
                    var books = bookRepository.FindAll(b => b.AuthorId.Equals(author.Id));

                    AuthorResponseDto authorDto = new AuthorResponseDto();
                    authorDto.Id = author.Id;
                    authorDto.FirstName = author.FirstName;
                    authorDto.LastName = author.LastName;
                    authorDto.Email = author.Email;
                    authorDto.Books = (List<BookWithoutAuthorDto>)mapper.Map<IEnumerable<BookWithoutAuthorDto>>(books.Result);
                    response.Add(authorDto);
                }

                return TypedResults.Ok(response);
            }
            catch (Exception ex)
            {
                return TypedResults.NotFound(ex);
            }
        }

        private static async Task<IResult> GetAuthor(IRepository<Author> repository, IRepository<Book> bookRepository, IMapper mapper, int id)
        {
            try
            {
                var author = await repository.Get(a => a.Id.Equals(id), a => a.Books);
                var books = bookRepository.FindAll(b => b.AuthorId.Equals(author.Id));
                if (author == null) return TypedResults.NotFound($"Author with {id} was not found");

                AuthorResponseDto authorDto = new AuthorResponseDto();
                authorDto.FirstName = author.FirstName;
                authorDto.LastName = author.LastName;
                authorDto.Email = author.Email;
                authorDto.Books = (List<BookWithoutAuthorDto>)mapper.Map<IEnumerable<BookWithoutAuthorDto>>(books.Result);

               
                return TypedResults.Ok(mapper.Map<AuthorResponseDto>(authorDto));
            }
            catch (Exception ex) 
            {
                return TypedResults.BadRequest(ex);
            }
        }

       
    }
}
