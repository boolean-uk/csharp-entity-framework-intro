using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
            var books = await _db.Books.Include(b => b.Author).ToListAsync();
            return books.MapListToDTO();
        }
    


        public async Task<DTOBook> GetBookById(int id)
        {
            var book = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);

            if (book is null) return null;

            _db.SaveChanges();

            return book.MapToDTO();
        }
            
     
        public async Task<DTOBook> UpdateById(int id, int authorId)
        {
            var book = await _db.Books.FirstOrDefaultAsync(b => b.Id == id);
            var author = await _db.Authors.FirstOrDefaultAsync(a => a.Id == authorId);

            if (book is null) return null;
            if (author is null) return null;

            book.AuthorId = author.Id;
            book.Author = author;
            await _db.SaveChangesAsync();
            return book.MapToDTO();

        }
        public DTOBook DeleteById(int Id)
        {
            var book = _db.Books.FirstOrDefault(x => x.Id == Id);
            _db.Books.Remove(book);
            _db.SaveChanges();
            return book.MapToDTO();
        }

        public async Task<DTOBook> AddBook(DTOBook book)
        {
            try
            {
                Book addedBook = new Book()
                {
                    Title = book.Title,
                    AuthorId = book.AuthorId
                };
                var id = _db.Books.Add(addedBook);
                await _db.SaveChangesAsync();
                DTOBook bookDTO = await GetBookById(addedBook.Id);
                return bookDTO;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


    }
}
