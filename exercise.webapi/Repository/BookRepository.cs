using exercise.webapi.Data;
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

        public async Task<Book> CreateBook(Book book)
        {
            book.Id = _db.Books.Last().Id + 1;
            foreach(int authorId in book.AuthorId)
            {
                book.Author.Add(await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId));
            }
            _db.Books.Add(book);
            await _db.SaveChangesAsync();
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == book.Id);

        }

        public async void DeleteBook(int id)
        {
            _db.Books.Remove(_db.Books.FirstOrDefault(b => b.Id == id));
            await _db.SaveChangesAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            await _db.Books.ForEachAsync(async b => b.Author = await updateAuthor(b.AuthorId));
            return await _db.Books.Include(b => b.Author).Include(b => b.Publisher).ToListAsync();
        }

        public async Task<Book> GetBook(int id)
        {
            Book book = await _db.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefaultAsync(b => b.Id == id);
            
            book.Author = await updateAuthor(book.AuthorId);
            return book;
        }

        public async Task<Book> PutAuthor(int id, int[] authorId)
        {
            Book b = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            b.AuthorId = authorId.ToList();
            foreach(int i in b.AuthorId)
            {
                b.Author.Add(await _db.Authors.FirstOrDefaultAsync(a => a.Id == i));
            }
            await _db.SaveChangesAsync();
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
        }

        private async Task<List<Author>> updateAuthor(List<int> authorId)
        {
            List<Author> authors = new();
            foreach (int id in authorId)
            {
                authors.Add(await _db.Authors.FirstOrDefaultAsync(a => a.Id == id));
            }
            return authors;
        }
    }
}
