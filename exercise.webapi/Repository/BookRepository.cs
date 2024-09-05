using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.DTO;
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

        public async Task<IEnumerable<DTOBook>> GetAllBooks()
        {
            List<DTOBook> dTOBooks = new List<DTOBook>();
            List<Book> books = await _db.Books.Include(b => b.Author).ToListAsync();
            foreach (Book book in books)
            {
                DTOBook dtobook = new DTOBook();
                dtobook.authorName = $"{book.Author.FirstName} {book.Author.LastName}";
                dtobook.AuthorID = book.AuthorId;
                dtobook.Title = book.Title;
                dtobook.Id = book.Id;
                dTOBooks.Add(dtobook);
            }
            return dTOBooks;

        }
        public async Task<DTOBook> GetBook(int id)
        {
            Book book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            DTOBook dtobook = new DTOBook();
            dtobook.authorName = $"{book.Author.FirstName} {book.Author.LastName}";
            dtobook.AuthorID = book.AuthorId;
            dtobook.Title = book.Title;
            dtobook.Id = book.Id;
            return dtobook;
        }
    }
}
