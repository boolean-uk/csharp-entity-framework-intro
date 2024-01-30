
using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;

namespace exercise.webapi.Repository
{ 
    public interface IAuthorRepository {

        public Task<Author> GetAuthor(int id);

        public Task<ICollection<Author>> GetAllAuthors();

        public Task<Author> DeleteAuthor(int authorId);

        public Task<ICollection<Author>> UpdateAuthor(int authorId, AuthorUpdatePayload payload);

        public Task<Author> AddAuthor(string FirstName, string LastName, ICollection<BookAuthor>? Books);
    }
}