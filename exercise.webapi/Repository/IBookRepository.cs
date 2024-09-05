using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<DTOBook>> GetAllBooks();

        public Task<DTOBook> GetBook(int id);
    }
}
