

using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
    
        public Task<IEnumerable<Author>> GetAuthors();

        public Task<Author?> GetAuthor(int authorId);

        public Task<Author?> DeleteAuthor(int authorID);
        public Task<Author?> CreateAuthor(string FirstName, string LastName, string Email);
        public Task<Author?> UpdateAuthor(int authorId, string newFirstName, string newLastName, string newEmail);
    }

}
