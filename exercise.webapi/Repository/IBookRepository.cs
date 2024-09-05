using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookResponseDTO>> GetAllBooks();
        public Task<BookResponseDTO> GetBook(int id);
        public Task<BookResponseDTO> UpdateBook(int id, BookUpdateData updateData);
        public Task<bool> DeleteBook(int id);
        public Task<BookResponseDTO> CreateBook(BookPostPayload bookData);
        public Task<bool> checkBookDataID(BookPostPayload bookData);
    }
}
