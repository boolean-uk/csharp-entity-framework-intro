using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetABook(int id);

        public Task<Book> AddBook(Book book);

        public Task<Book> UpdateBook(Book toUpdate);

        public Task<Book> DeleteBook(int id);

        public Task<bool> CheckIfAuthor(int authorId);
    }
}
