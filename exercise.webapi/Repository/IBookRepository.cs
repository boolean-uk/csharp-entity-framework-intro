using exercise.webapi.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book>GetBook(int id);
        public Task<Book> UpdateBook(int id, int author_id);
        public Task<IEnumerable<Author>> GetAllAuthor();
        public Task<Author> GetAuthor(int id);
        public Task<Book> DeleteBook(int id);
        public Task<Book> CreateBook(string title, int author_id, int publisher_id);
        public Task<IEnumerable<Publisher>> GetAllPublishers();
        public Task<Publisher> GetPublisher(int id);

    }
}
