using exercise.webapi.DTOs;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<BookDTO> CreateBook(CreateBookDTO bookDto);

        public Task<IEnumerable<BookDTO>> GetAllBooks();

        public Task<BookDTO> GetBookById(int id);

        public Task<BookDTO> UpdateBookAuthorById(int id, int authorId);

        public Task DeleteBookById(int id);
    }
}
