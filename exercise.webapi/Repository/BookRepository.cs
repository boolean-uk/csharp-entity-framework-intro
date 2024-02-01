using exercise.webapi.Data;
using exercise.webapi.Models.DTOs;
using exercise.webapi.Models.InputTypes;
using exercise.webapi.Models.Types;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class BookRepository: IBookRepository
    {
        DatabaseContext _db;
        
        public BookRepository(DatabaseContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<BookWithAuthorDTO>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).ToListAsync();
            var returnList = new List<BookWithAuthorDTO>();
            foreach (var book in books)
            {
                returnList.Add(BookWithAuthorDTO.bookToDTO(book));
            }
            return returnList;
        }

        public async Task<BookWithAuthorDTO?> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            if (book == null)
                return null;

            return BookWithAuthorDTO.bookToDTO(book);
        }

        public async Task<BookWithAuthorDTO?> UpdateBook(int id, BookPost newBook)
        {
            var bookToUpdate = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            if (bookToUpdate == null) return null;
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newBook.AuthorId);
            if (author == null) return null;
            newBook.Title = !string.IsNullOrEmpty(newBook.Title) ? bookToUpdate.Title = newBook.Title : null!;
            bookToUpdate.Author = author;
            await _db.SaveChangesAsync();
            return BookWithAuthorDTO.bookToDTO(bookToUpdate);
        }

        public async Task<BookWithAuthorDTO?> DeleteBook(int id)
        {
            var bookToDelete = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(x => x.Id == id);
            if (bookToDelete == null) return null;
            _db.Books.Remove(bookToDelete);
            await _db.SaveChangesAsync();
            return BookWithAuthorDTO.bookToDTO(bookToDelete);
        }

        public async Task<BookWithAuthorDTO?> CreateBook(BookPost newBook)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newBook.AuthorId);
            if (author == null) return null;
            Book book = new Book()
            {
                Title = newBook.Title,
                Author = author,
            };
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return BookWithAuthorDTO.bookToDTO(book);
        }

        public async Task<int> GetNewId()
        {
            return await _db.Books.MaxAsync(x => x.Id);
        }
    }
}
