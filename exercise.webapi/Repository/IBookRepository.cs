using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);
        public Task<IEnumerable<Author>> GetAllAuthors();


        public Task<Author> GetAuthor(int id);
        public Task<Book> AddBook(Book book);

        public Task<Book> UpdateBook(Book book);

        public Task<IEnumerable<Book>> GetBooksByAuthorId(int id);

    }
}
