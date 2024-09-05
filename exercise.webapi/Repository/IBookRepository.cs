using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookGetModel>> GetAllBooks();
        public Task<BookGetModel> GetBook(int id);
        public Task<BookGetModel> UpdateBook(int id, BookUpdateModel model);
        public Task<BookGetModel> DeleteBook(int id);
        public Task<BookGetModel> CreateBook(BookCreateModel model);
    }
}
