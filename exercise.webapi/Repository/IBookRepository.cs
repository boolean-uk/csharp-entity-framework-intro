using exercise.webapi.DTO;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        public Task<IEnumerable<DTOBook>> GetAllBooks();

        public Task<DTOBook> GetBook(int id);

        public Task<DTOBook> UpdateBook(DTOBook book, int AuthorID);

        public Task<DTOBook> DeleteBook(int book);

        public Task<DTOBook> AddBook(DTOBook book);
    }
}
