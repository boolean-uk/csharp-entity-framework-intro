using exercise.webapi.AlternativeModels;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetBook(int id);

        public Task<Book> UpdateBook(int id, int authorId);

        public Task<Book> DeleteBook(int id);

        public Task<Payload<Book>> CreateBook(PostBook postBook);

        public Task<Author> GetAuthor(int id);

        public Task<List<Author>> GetAuthors();
    }
}
