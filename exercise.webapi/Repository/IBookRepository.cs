using exercise.webapi.Models;
using exercise.webapi.Models.DTOs;

namespace exercise.webapi.Repository
{
    public interface IBookRepository
    {
        // ----- Book -----
        public Task<IEnumerable<Book>> GetAllBooks();

        Task<Book> GetBookById(int id);

        Task<Book> UpdateBooksAuthor(int id, int authorId);

        Task<Book> DeleteBook(int id);

        Task<Book> CreateBook(CreateBookDto newBook);

        // ----- Author -------
        Task<IEnumerable<AuthorDto>> GetAllAuthors();
        int GetAmountOfAuthors(); 
        Task<IEnumerable<BookDto>> GetBooksByAuthorId(int authorId);

        // ------- Publisher ---------
        Task<IEnumerable<PublisherDto>> GetAllPublishers();
        Task<IEnumerable<BookDto>> GetBooksByPublisherId(int publisherId); 

    }
}
