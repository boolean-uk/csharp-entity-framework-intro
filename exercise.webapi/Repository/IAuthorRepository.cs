

using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore.Diagnostics;


namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
    
        public Task<IEnumerable<Author>> GetAuthorsAsync();

        public Task<Author?> GetAuthor(int authorId);

        public void SaveChanges();
    }

}
