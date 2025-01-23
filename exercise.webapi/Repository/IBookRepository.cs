using exercise.webapi.DTO;
using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<bool> Delete(int bookid);
        public Task<IEnumerable<BookDto>> GetAllBooks();
        Task<BookDto> GetBook(int id);
        public Task<BookDto> Update(int bookid, int authorId);
        public Task<BookDto> CreateBook(string title, int authorid);
        public Task<List<string>> findBooksByAuthor(int authorid);
        public Task<BookDto> GetAuthor(int id);
        public Task<List<AuthorDto>> GetAllAuthors();
    }
}
