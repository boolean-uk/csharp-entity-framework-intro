using System.Reflection.Emit;
using exercise.webapi.Models;
using exercise.webapi.Repository;

namespace exercise.webapi.Services
{
    public class BookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository repository)
        {
            _bookRepository = repository;
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

        public BookDTO ConvertToBookDTO(Book book)
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
                }
            };

            return bookDTO;
        }
    }
}
