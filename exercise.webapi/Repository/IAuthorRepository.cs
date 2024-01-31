using exercise.webapi.Models;

namespace exercise.webapi.Repository;

public interface IAuthorRepository
{
    public Task<IEnumerable<AuthorWithBooksDTO>> GetAllAuthors();
    public Task<AuthorWithBooksDTO?> GetAuthorById(int id);
}
