using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }


        public async Task<IEnumerable<BookResponseDTO>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).Include(b=>b.Publisher).ToListAsync();
            List<BookResponseDTO> result = new List<BookResponseDTO>();
            foreach (var book in books)
            {
                result.Add(PutBookInDTO(book));
            }
            _db.SaveChanges();
            return result;

        }

        public async Task<BookResponseDTO> GetBook(int id)
        {
            

            var book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).SingleOrDefaultAsync(b => b.Id == id);
            BookResponseDTO bookResponseDTO = PutBookInDTO(book);
            _db.SaveChanges();
            return bookResponseDTO;


        }

        public async Task<BookResponseDTO> UpdateBook(int id, BookUpdateData updateData)
        {
            var book = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);

            if (book == null)
            {
                return null;
            }
            UpdateBookValues(book, updateData);

            BookResponseDTO bookResponseDTO = PutBookInDTO(book);
            
            _db.SaveChanges();
            return bookResponseDTO;
        }
        public async Task<bool> DeleteBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);

            if (book == null) return false;

            _db.Books.Remove(book);

            _db.SaveChanges();
            return true;
        }

        public async Task<BookResponseDTO> CreateBook(BookPostPayload bookData)
        {
            
            var author = await _db.Authors.SingleOrDefaultAsync(a => a.Id == bookData.authorId);
            
            Book book = new Book() { Title = bookData.title, AuthorId = bookData.authorId, Author = author };

            _db.Books.Add(book);
            BookResponseDTO result = PutBookInDTO(book);
            _db.SaveChanges();
            return result;
           
        }

        private BookResponseDTO PutBookInDTO(Book? book)
        {
            BookResponseDTO responseDTO = new BookResponseDTO();
            if(book != null)
            {

                responseDTO.Title = book.Title;
                responseDTO.Id = book.Id;
                responseDTO.AuthorId = book.Author.Id;
                responseDTO.Author.Id = book.Author.Id;
                responseDTO.Author.FirstName = book.Author.FirstName;
                responseDTO.Author.LastName = book.Author.LastName;
                responseDTO.Author.Email = book.Author.Email;

                return responseDTO;
            }
            else
            {
                throw new Exception("book was null");
            }

            
        }
        private async void UpdateBookValues(Book book, BookUpdateData updateData)
        {
            
            var Author = await _db.Authors.SingleOrDefaultAsync(a => a.Id == updateData.authorID);
            if (Author == null)
            {
                throw new Exception("Not a valid author id");
            }
            else
            {
                book.Author = Author;
            }

            
        }

        public async Task<bool> checkBookDataID(BookPostPayload bookData)
        {
            

            var author = await _db.Authors.FindAsync(bookData.authorId);
            

            if (author == null) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
