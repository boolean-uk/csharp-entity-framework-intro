using System.Reflection.Emit;
using exercise.webapi.Models;
using exercise.webapi.Repository;
using exercise.wwwapi.Helpers;

namespace exercise.webapi.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPublisherRepository _publisherRepository;
        private readonly IdGenerator _idGenerator;

        public BookService(IBookRepository repository, IAuthorRepository authorRepository, IPublisherRepository publisherRepository, IdGenerator idGenerator)
        {
            _bookRepository = repository;
            _authorRepository = authorRepository;
            _publisherRepository = publisherRepository;
            _idGenerator = idGenerator;
        }

        public async Task<List<BookDTO>> GetBooks()
        {
            var books = await _bookRepository.GetAllBooks();
            List<BookDTO> booksDTO = new List<BookDTO>();
            
            foreach(var book in books)
            {
                BookDTO bookDTO = ConvertToBookDTO(book);
                booksDTO.Add(bookDTO);
            }

            return booksDTO;
        }

        public async Task<BookDTO> GetBook(int id)
        {
            Book book = await _bookRepository.GetBook(id);

            if (book == null)
                return null;

            var bookDTO = ConvertToBookDTO(book);

            return bookDTO;
        }

        public async Task<BookDTO> UpdateBook(int id, UpdateBookAuthorDTO updateDTO)
        {
            Book updatedBook = await _bookRepository.UpdateBook(id, updateDTO);

            var bookDTO = ConvertToBookDTO(updatedBook);

            return bookDTO;
        }

        public async Task<BookDTO> DeleteBook(int id)
        {
            Book book = await _bookRepository.DeleteBook(id);

            var bookDTO = ConvertToBookDTO(book);

            return bookDTO;
        }

        public async Task<BookDTO> CreateBook(CreateBookDTO createDTO)
        {
            var author = await _authorRepository.GetAuthor(createDTO.AuthorId);
            var publisher = await _publisherRepository.GetPublisher(createDTO.PublisherId);

            Book book = new Book
            {
                Id = _idGenerator.GetBookId(),
                Title = createDTO.Title,
                AuthorId = author.Id,
                Author = author,
                PublisherId = publisher.Id,
                Publisher = publisher
            };

            book = await _bookRepository.CreateBook(book);

            var bookDTO = ConvertToBookDTO(book);

            return bookDTO;
        }

        private BookDTO ConvertToBookDTO(Book book)
        {

            var bookDTO = new BookDTO
            {
                Id = book.Id,
                Title = book.Title,
                AuthorId = book.AuthorId,
                Author = new AuthorDTO
                {
                    Id = book.Author.Id,
                    FirstName = book.Author.FirstName,
                    LastName = book.Author.LastName,
                    Email = book.Author.Email
                },
                PublisherId = book.Publisher.Id,
                Publisher = new PublisherDTO
                {
                    Id = book.Publisher.Id,
                    Name = book.Publisher.Name
                }
            };

            return bookDTO;
        }
    }
}
