using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class Repository: IRepository
    {
        DataContext _db;
        
        public Repository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> GetBookById(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstAsync(x=>x.Id==id);
        }

        public async Task<Book> UpdateBook(int id, int NewAuthorId)
        {
            var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            book.AuthorId = NewAuthorId;
            book.Author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == book.AuthorId);

            _db.SaveChangesAsync();

            return await GetBookById(id);
        }
        public async Task<Book> DeleteBook(int id)
        {
            var book = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);

            _db.Books.Remove(book);
            _db.SaveChangesAsync();

            return book;
        }
        public async Task<Book> CreateBook(Book book)
        {
            var author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == book.AuthorId);
            if (author == null) { return null; }

            book.Author = author;
            _db.Books.Add(book);
            _db.SaveChangesAsync();

            return book;
        }
        public async Task<AuthorDTO> GetAuthorById(int id)
        {
            AuthorDTO outputAuthor = new AuthorDTO();
            Author getAuthor = await _db.Authors.FirstOrDefaultAsync(x =>  id == x.Id);
            if (getAuthor == null) { return null; }
            outputAuthor.Id = getAuthor.Id;
            outputAuthor.FirstName = getAuthor.FirstName;
            outputAuthor.LastName = getAuthor.LastName;
            outputAuthor.Email = getAuthor.Email;
            foreach(var book in await _db.Books.Where(x=>x.AuthorId==getAuthor.Id).ToListAsync())
            {
                BookDTO bookDTO = new BookDTO();
                bookDTO.Id = book.Id;
                bookDTO.Title = book.Title;
                outputAuthor.Books.Add(bookDTO);
            }
            return outputAuthor;
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthors()
        {
            var result = new List<AuthorDTO>();
            foreach(var author in _db.Authors)
            {
                result.Add(await GetAuthorById(author.Id));
            }
            return result;
        }
    }
}
