using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<Book>> GetAllBooks();
        public Task<Book>? GetBook(int Id);

        public Task<Author> CreateBook(int authorId, BookCreatePayload book);

        public Task<Book> DeleteBook(int Id);
        public Task<Book> UpdateBook(int Id, BookUpdateDTO payload);

    }
}
