using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        Task<Book> AddBook(NewBookDTO newBook);
        Task<Book> DeleteBook(int? id);
        
        Task<Book> GetABook(int? id);
        public Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> UpdateBook(int? id, UpdateAuthorDTO newAuthor);
    }
}
