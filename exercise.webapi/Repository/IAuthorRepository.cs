using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IAuthorRepository
    {
        Task<IEnumerable<DTOAuthor>> GetAllAuthors(); 
        Task<DTOAuthor> GetAuthor(int id);

    }
}
