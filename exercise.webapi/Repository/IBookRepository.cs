using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<ResponseBookDTO>> GetAllBooks();

        public Task<ResponseBookDTO> GetBook(int id);
        public Task<ResponseBookDTO> UpdateBook(int id, BookUpdate data);
        public Task<bool> DeleteBook(int id);
        public Task<ResponseBookDTO> AddBook(BookPost data);
        public Task<bool> CheckBookDataId(BookPost data);
    }
}
