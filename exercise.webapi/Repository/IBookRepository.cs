using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
       
        public Task<IEnumerable<Book>> GetBooksAsync();
        public Task<Book?> GetBook(int bookId);
        public Task<Book?> UpdateBookAuthor(int bookId, int newAuthorId);
        public Task<Book?> DeleteBookAuthor(int bookId);
        public void SaveChanges();
    }
}
