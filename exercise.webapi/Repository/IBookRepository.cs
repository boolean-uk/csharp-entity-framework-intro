using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<Book> AddBook(string title, string authorFirstName, string authorLastName);
        public Task<Book> DeleteBook(string title);
        public Task<Book> GetABook(string title);
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book> UppdateBook(string title, string newTitle);
    }
}
