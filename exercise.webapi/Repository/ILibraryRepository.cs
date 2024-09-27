using exercise.webapi.Models;

namespace exercise.webapi.Repository
{
    public interface ILibraryRepository
    {
        public Task<IEnumerable<BookDto>> GetAllBooks();
        public Task<BookDto> GetBook(int id);
        public Task<BookUpdateDto> UpdateBook(int id, int newId);
        public Task<BookDto> DeleteBook(int id);
        public Task<Book> CreateBook(BookCreateDto book, int authorId, int publisherId);

        public Task<IEnumerable<AuthorDto>> GetAllAuthors();
        public Task<AuthorDto> GetAuthor(int id);

        public Task<IEnumerable<PublisherDto>> GetAllPublishers();
        public Task<PublisherDto> GetPublisher(int id);
    }
}
