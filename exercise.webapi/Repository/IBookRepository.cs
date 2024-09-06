using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookDTO>> GetAllBooks();
        public Task<BookDTO> GetBook(int Id);
        //need author object in book so create it at collection?
        public Task<BookDTO> UpdateBook(int Id, string Title, int AuthorId);
        public Task<BookDTO> CreateBook(string Title, int AuthorId);
        public BookDTO DeleteBook(int Id);
    }
}
