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

        public async Task<Book> Add(Book book)
        {
            await _db.Books.AddAsync(book);
            await _db.SaveChangesAsync();
            return  await _db.Books.Include(a => a.Author).FirstOrDefaultAsync(x => x.Id == book.Id) ;
        }

        public async Task<Book> Delete(int id)
        {
            var target = await _db.Books.FirstOrDefaultAsync(x => x.Id == id);
            _db.Remove(id);
            await _db.SaveChangesAsync();
            return  target;
        }


        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book>  GetProdById(int id)
        {
            return await _db.Books.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<Book> Update(Book bok1, int id)
        {
            var chosenBook = await _db.Books.FirstOrDefaultAsync(p => p.Id == id);
            chosenBook.Author = bok1.Author;
            await _db.SaveChangesAsync();
            return chosenBook;
        }
    }
}
