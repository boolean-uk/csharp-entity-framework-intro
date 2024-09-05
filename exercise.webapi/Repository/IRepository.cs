using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        Task<Book> GetBookById(int id);

        Task<Book> Add(PostBook model);

        Task<Book> Update(int bookId, int authorId);

        Task<IEnumerable<Book>> Delete(int id);

        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Author> GetAuthorById(int id);
        Task<Publisher> GetPublisherById(int id);
        Task<IEnumerable<Publisher>> GetAllPublishers();

        Task<IEnumerable<BookAuthor>> GetAllBookAuthors();

        Task<IEnumerable<BookAuthor>> GetBookAuthorsByBookId(int id);

        Task<IEnumerable<BookAuthor>> GetAllAuthorBooks();


        Task<IEnumerable<BookAuthor>> GetAuthorBooksByAuthorId(int bookId);

    }
}
