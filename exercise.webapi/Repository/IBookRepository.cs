using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();

        public Task<Book> GetBookById(int bookID);

        public Task<Book> UpdateBookByID(int bookID, string firstname, string lastname);

        public Task<Book> DeleteBookByID(int bookID);

        public Task<Book> CreateNewBook(string title, int authorID, int publisherID);
    }
}
