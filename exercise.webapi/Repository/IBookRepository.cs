using exercise.webapi.Models;
using exercise.webapi.Models.DatabaseModels;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        //public Task<IEnumerable<Book>> GetAllBooks();
        public Task<IEnumerable<BookDto>> GetAllBooks();
        public Task<BookDto> GetBook(int id);
        public Task<BookDto> AddBook(BookDto bookDto);
        public Task<BookDto> UpdateBook(int id, int newAuthorId);
        public Task<BookDto> DeleteBook(int id);

        Task<IEnumerable<AuthorDto>> GetAllAuthors();
        Task<AuthorDto> GetAuthor(int id);

    }
}
