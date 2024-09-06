using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> Add(Book entity);
        Task<Book> Update(Book bok1, int id);
        Task<Book> Delete(int id);
        Task<Book> GetProdById(int id);   
    }
}
