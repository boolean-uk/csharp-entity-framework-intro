using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<GetBookDto>> GetAllBooks();

        public Task<GetBookDto> GetBook(int id);

        public Task<GetBookDto> UpdateAuthor(int bookId, int authorId);
        public Task<GetBookDto> DeleteBook(int id);

        public Task<CreateBookDto> CreateBook(CreateBookDto book);

        public Task<GetBookDto> AssignAuthor(int id, int authorId);
        public Task<GetBookDto> RemoveAuthor(int id);
    }





}
