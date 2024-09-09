using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBookById(int id);
        Task<Book> UpdateById(int id, Book entity); //Do I really need ID here or is the entity enough?
        Task <Book> DeleteById(int id);
        Task<Book> CreateBook(Book entity);

    }
}
