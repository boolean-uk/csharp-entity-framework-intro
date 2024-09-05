using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<BookDTO> GetBook(int Id);
        //need author object in book so create it at collection?
        public Task<Book> UpdateBook(int Id, string Title, int AuthorId);
        public Task<Book> CreateBook(string Title, int AuthorId);
        public Book DeleteBook(int Id);
    }
}
