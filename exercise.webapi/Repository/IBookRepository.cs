using exercise.webapi.Models.DTOs;
using exercise.webapi.Models.InputTypes;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookWithAuthorDTO>> GetAllBooks();
        public Task<BookWithAuthorDTO?> GetBookById(int id);
        public Task<BookWithAuthorDTO?> UpdateBook(int id, BookPost newBook);
        public Task<BookWithAuthorDTO?> DeleteBook(int id);
        public Task<BookWithAuthorDTO?> CreateBook(BookPost newBook);
        public Task<int> GetNewId();
    }
}
