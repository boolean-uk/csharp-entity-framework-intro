using exercise.webapi.Data;
using exercise.webapi.DTO;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace exercise.webapi.Repository
{
    public class BookRepository : IBookRepository
    {
        DataContext _db;
        
        public BookRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<ResponseBookDTO> AddBook(BookPost data)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(a=>a.Id == data.authorId);
            Book book = new Book()
            {
                Title = data.title,
                AuthorId = data.authorId,
                Author = author
            };
            _db.Books.Add(book);
            ResponseBookDTO response = PutBook(book);
            _db.SaveChanges();
            return response;
        }

        public async Task<bool> CheckBookDataId(BookPost data)
        {
            var result = await _db.Authors.FindAsync(data.authorId);
            if(result != null)
            {
                return true;
            }
            return false;
        }

        public async Task<bool> DeleteBook(int id)
        {
            var book = await _db.Books.Include(b=>b.Author).SingleOrDefaultAsync(b=>b.Id == id);
            if(book != null)
            {
                _db.Books.Remove(book);
                _db.SaveChanges();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<ResponseBookDTO>> GetAllBooks()
        {
            var books = await _db.Books.Include(b => b.Author).ToListAsync();   
            List<ResponseBookDTO> result = new List<ResponseBookDTO>();
            foreach (var book in books)
            {
                result.Add(PutBook(book));
            }
            _db.SaveChanges();
            return result;
        }

        public async Task<ResponseBookDTO> GetBook(int id)
        {
            var book = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b => b.Id == id);
            ResponseBookDTO response = PutBook(book);
            _db.SaveChanges();
            return response;
        }

        public async Task<ResponseBookDTO> UpdateBook(int id, BookUpdate data)
        {
            var book = await _db.Books.Include(b => b.Author).SingleOrDefaultAsync(b=> b.Id == id);
            if(book != null)
            {
                UpdateValues(book, data);
                ResponseBookDTO result = PutBook(book);
                _db.SaveChanges();
                return result;
            }
            return null;
        }

        private ResponseBookDTO PutBook(Book? book)
        {
            ResponseBookDTO result = new ResponseBookDTO();
            if(book != null)
            {
                result.Author.Id = book.Author.Id;
                result.AuthorId = book.Author.Id;
                result.Id = book.Id;
                result.Title = book.Title;
                result.Author.Email = book.Author.Email;
                result.Author.FirstName = book.Author.FirstName;
                result.Author.LastName = book.Author.LastName;
                return result;
            }
            throw new Exception("Something went wrong, book was null!");
        }

        private async void UpdateValues(Book book, BookUpdate data)
        {
            var author = await _db.Authors.SingleOrDefaultAsync(a => a.Id == data.authorId);
            if (author == null)
            {
                throw new Exception("Something went wrong, invalid id!");
            }
            book.Author = author;
        }
    }

}
