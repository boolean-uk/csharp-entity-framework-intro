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
            var entity = await _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefaultAsync(b => b.Id == id);
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
            var books = await _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).ToListAsync();

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
            var entity = await _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefaultAsync(b => b.Id == id);
            if (entity == null)
            {
                throw new Exception("Book not found");
            }

            //Response
            var response = ConstructBookResponse(entity);
            return response;
        }

        public async Task<BookResponse> UpdateBook(int bookId, List<int> authorIds)
        {
            //Find the book
            var entity = await _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            if (entity == null)
            {
                throw new Exception("Book not found");
            }

            //Update
            if(entity.BookAuthors == null)
            {
                throw new Exception("Bookauthors doesn't exist");
            }
            entity.BookAuthors.Clear();
            foreach (var Id in authorIds)
            {
                entity.BookAuthors.Add(new BookAuthor() { BookId = bookId, AuthorId = Id });
            }
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
