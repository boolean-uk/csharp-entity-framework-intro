using exercise.webapi.DTO;
using exercise.webapi.Models;
using System.Runtime.CompilerServices;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<BookDto>> GetAllBooks();

        public Task<BookDto> GetById(int id);

        public Task<Book> Update(int id, int authorId);

        public Task<BookDto> Delete(int id);

        public Task<Book> Create(BookPost book2, int authorId);
    }
}
