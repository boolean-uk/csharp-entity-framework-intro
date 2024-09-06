using exercise.webapi.Data;
using exercise.webapi.Models;
using exercise.webapi.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private DataContext _db;

        public AuthorRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<List<AuthorResponse>> GetAllAuthors()
        {
            //Get authors
            var authors = await _db.Authors.Include(b => b.BookAuthors).ThenInclude(ba => ba.Book).ToListAsync();

            //Response
            List<AuthorResponse> response = new List<AuthorResponse>();
            foreach (var author in authors)
            {
                response.Add(ConstructAuthorResponse(author));
            }
            return response;
        }

        public async Task<AuthorResponse> GetAuthor(int id)
        {
            //Get author
            var author = await _db.Authors.Include(a => a.BookAuthors).ThenInclude(ab => ab.Book).FirstOrDefaultAsync(a => a.Id == id);
            if (author == null)
            {
                throw new Exception("Author not found");
            }

            //Response
            var response = ConstructAuthorResponse(author);
            return response;
        }

        public async Task<AuthorResponse> AssignAuthor(int bookId, int authorId)
        {
            //Get author
            var author = await _db.Authors.Include(a => a.BookAuthors).ThenInclude(ab => ab.Book).FirstOrDefaultAsync(a => a.Id == authorId);
            if (author == null)
            {
                throw new Exception("Author not found");
            }

            //Get book
            var book = await _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            //Assign the author to the book
            book.BookAuthors.Add(new BookAuthor() { BookId = bookId, AuthorId = authorId });
            _db.Attach(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();

            //Response
            var response = ConstructAuthorResponse(author);
            return response;
        }

        public async Task<AuthorResponse> RemoveAuthor(int bookId, int authorId)
        {
            //Get author
            var author = await _db.Authors.Include(a => a.BookAuthors).ThenInclude(ab => ab.Book).FirstOrDefaultAsync(a => a.Id == authorId);
            if (author == null)
            {
                throw new Exception("Author not found");
            }

            //Get book
            var book = await _db.Books.Include(b => b.BookAuthors).ThenInclude(ba => ba.Author).FirstOrDefaultAsync(b => b.Id == bookId);
            if (book == null)
            {
                throw new Exception("Book not found");
            }

            //Get the BookAuthor object to remove
            foreach(var bookAuthor in book.BookAuthors)
            {
                if(bookAuthor.AuthorId == authorId)
                {
                    book.BookAuthors.Remove(bookAuthor);
                    await _db.SaveChangesAsync();
                    break;
                }
            }

            //Response
            var response = ConstructAuthorResponse(author);
            return response;
        }

        private AuthorResponse ConstructAuthorResponse(Author author)
        {
            //Construct response
            var response = new AuthorResponse(author);
            return response;
        }
    }
}
