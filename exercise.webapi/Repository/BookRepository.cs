using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.ViewModels;
using Microsoft.EntityFrameworkCore;
using System.Net;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<BookResponse> AddBook(Book entity)
        {
            //Add the book
            await _db.AddAsync(entity);
            await _db.SaveChangesAsync();

            //Response
            var response = ConstructBookResponse(entity);
            return response;
        }

        public async Task<BookResponse> DeleteBook(int id)
        {
            //Find the book
            var entity = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (entity == null)
            {
                throw new Exception("Book not found");
            }
            //Remove the book
            _db.Books.Remove(entity);
            await _db.SaveChangesAsync();

            //Response
            var response = ConstructBookResponse(entity);
            return response;
        }

        public async Task<IEnumerable<BookResponse>> GetAllBooks()
        {
            //Get books
            var books = await _db.Books.Include(b => b.Author).ToListAsync();

            //Response
            List<BookResponse> response = new List<BookResponse>();
            foreach (var book in books)
            {
                response.Add(ConstructBookResponse(book));
            }
            return response;
        }

        public async Task<BookResponse> GetBook(int id)
        {
            //Get book
            var entity = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (entity == null)
            {
                throw new Exception("Book not found");
            }

            //Response
            var response = ConstructBookResponse(entity);
            return response;
        }

        public async Task<BookResponse> UpdateBook(int bookId, int authorId)
        {
            //Find the book
            var entity = await _db.Books.Include(b => b.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            if (entity == null)
            {
                throw new Exception("Book not found");
            }

            //Update
            entity.AuthorId = authorId;
            _db.Attach(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            //Response
            var response = ConstructBookResponse(entity);
            return response;
        }

        private BookResponse ConstructBookResponse(Book book)
        {
            //Construct response
            var response = new BookResponse(book);
            return response;
        }
    }
}
