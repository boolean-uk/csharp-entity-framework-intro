using exercise.webapi.Models;
using exercise.webapi.Models.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<List<Author_DTO_2>> getAll();
        Task<Author_DTO_2> getAuthor(int id);
    }
}
