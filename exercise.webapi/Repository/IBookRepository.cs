using exercise.webapi.Models.BaseModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAll();
        public Task<Book> Get(int id);
        public Task<Book> Update(Book book);
    }
}
