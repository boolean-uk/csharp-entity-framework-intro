using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        //public Task<IEnumerable<Book>> GetAllBooks(); Previous code, no longer needed
        public Task<IEnumerable<BookDTO>> GetAllBooks();
        public Task<BookDTO> GetBook(int bookId);
        public Task<Book> CreateBook(Book newBook);
        public Task<Book> UpdateBook(int bookId, Book updatedBook);
        public Task<bool> DeleteBook(int bookId);
    }
}
