using exercise.webapi.DTOs;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<GetBookDTO>> GetAllBooks();
        public Task<GetBookDTO> GetBookById(int id);
        public Task<GetBookDTO> UpdateBookAuthor(int bookId, int authorId);
        public Task<GetBookDTO> DeleteBookById(int id);
        public Task<CreateBookDTO> CreateBook(CreateBookDTO book);
    }
}
