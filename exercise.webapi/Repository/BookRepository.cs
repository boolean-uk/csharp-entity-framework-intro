using exercise.webapi.Data;
using exercise.webapi.DTOs;
using exercise.webapi.DTOs.BookApi;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<Book> AddBook(BookPostModel bookmodel)
        {
            Book newbook = new Book();
            newbook.Title = bookmodel.Title;
            newbook.AuthorId = bookmodel.AuthorId;
            Author author = new Author();
            author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == bookmodel.AuthorId);
            newbook.Author = author;

            await _db.AddAsync(newbook);
            await _db.SaveChangesAsync();
            return newbook;
            
        }

        public async Task<Book> DeleteBook(int id)
        {
            Book deletedBook = await GetABook(id);

            if (deletedBook != null) 
            {
                _db.Books.Remove(deletedBook);
                await _db.SaveChangesAsync();
            }
            
            return deletedBook;
        }

        public async Task<Book> GetABook(int id)
        {
            return await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);

        }

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books.Include(b => b.Author).ToListAsync();

        }

        public async Task<Book> UpdateBook(Book book)
        {
            Author newauthor = await _db.Authors.FirstOrDefaultAsync(a => a.Id == book.Id);
            book.Author = newauthor;
            _db.Attach(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
