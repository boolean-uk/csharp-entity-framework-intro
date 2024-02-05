using exercise.webapi.Models.DTO;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<GetBookDTO?> GetBookById(int id);
        public Task<IEnumerable<GetBookDTO>> GetAllBooks();
        public Task<GetBookDTO?> ChangeAuthorById(UpdateBookAuthorDTO updateDTO);
        public Task<int> DeleteBookById(int id);
        public Task<int> CreateBook(CreateBookDTO createDTO);
    }
}
