using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<DTOBook>> GetAllBooks(); // Task<List<Bottle>> GetBottles();
        Task<DTOBook> GetBookById(int id);
        Task<DTOBook> AddBook(DTOBook book);
        Task<DTOBook> UpdateById(int id, int AuthorId);
        public DTOBook DeleteById(int id);
    }
}
