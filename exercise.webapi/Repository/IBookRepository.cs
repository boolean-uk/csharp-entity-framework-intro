using exercise.webapi.AlternativeModels;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetBook(int id);

        public Task<Book> UpdateBook(Book book);

        public Task<Book> DeleteBook(int id);

        public Task<Book> CreateBook(Book book);

        public Task<Author> GetAuthor(int id);

        public Task<List<Author>> GetAuthors();

        public Task<List<Publisher>> GetPublishers();

        public Task<Publisher> GetPublisher(int id);
    }
}
