using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository
    {
        public Task<List<Book>> GetAllBooks();

        //Task<Book> AddBook(Book book);

        Task<Book> GetBook(int id);

        Task<Book> CreateAsync(Book model);

        //Task<Book?> UpdatedAsync(int id, AddBookDTO model);
        Task<Book> UpdateBook(Book book);
        Task<Book?> DeleteAsync(int id);



        public Task<List<Author>> GetAllAuthor();

        Task<Author> GetAuthor(int id);
    }
}
