using System.Security;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> GetAuthor(int id);
        Task<Author> AddAuthorBook(int id, Book book);

    }
}
