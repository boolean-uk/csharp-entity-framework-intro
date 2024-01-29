using exercise.webapi.Models;
using Microsoft.Extensions.Hosting;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book?> GetBookById(int id);
    }
}
