using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> GetBook(int id);
        public Task<Book> UpdateBookAuthor(int id, Book book);
        public Task<Book> DeleteBook(int id);
        public Task<Book> CreateBook(Book book);
        public Task<IEnumerable<Author>> GetAllAuthors();
        public Task<Author> GetAuthor(int id);

        public Task<IEnumerable<Publisher>> GetAllPublishers();
    }
}
