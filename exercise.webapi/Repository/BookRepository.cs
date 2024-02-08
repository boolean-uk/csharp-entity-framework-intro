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

        public async Task<IEnumerable<Book>> GetAllBooks()
        {
            return await _db.Books
               .Include(b => b.Publisher)
               .Include(a => a.Bookauthors)
               .ThenInclude(ba => ba.Author)
               .OrderBy(b => b.Id)
               .ToListAsync();

        }

        public async Task<Book> GetABook(int id)
        {
            var entity = await _db.Books
                .Include (b => b.Publisher)
                .Include(a => a.Bookauthors)
                .ThenInclude(c => c.Author)
                .FirstAsync(a => a.Id == id);
            return entity;
        }

        public async Task<Book> UpdateBook(int bookId, BookPut model)
        {
           var book = await _db.Books
                .Include(a =>a.Publisher)
                .Include(ba => ba.Bookauthors)
                .ThenInclude (ba => ba.Author)
                .FirstOrDefaultAsync(a => a.Id == bookId);

            if (book != null)
            {
                if (model.PublisherId > 0)
                {
                    var publisher = await _db.Publishers.FindAsync(model.PublisherId);
                    if(publisher != null)
                    {
                        book.PublisherId = publisher.Id;
                        book.Publisher = publisher;
                    }
                }
                if(model.AuthorIds != null && model.AuthorIds.Any())
                {
                    _db.BookAuthors.RemoveRange(book.Bookauthors);

                    foreach(var authorid in model.AuthorIds)
                    {
                        var entity = await _db.Authors.FindAsync(authorid);
                        if(entity != null)
                        {
                            var bookAuthor = new BookAuthor
                            {
                                Book = book,
                                Author = entity
                            };
                            _db.BookAuthors.Add(bookAuthor);
                        }
                    }
                }

                await _db.SaveChangesAsync();
            }

            return book;
        }

        public async Task<Book> DeleteBook(int id)
        {
            var book = _db.Books
                .Include(p => p.Publisher)
                .Include(ba => ba.Bookauthors)
                .ThenInclude(a => a.Author)
                .FirstOrDefault(x => x.Id == id);

            if(book != null)
            {
                _db.Books.Remove(book);
                await _db.SaveChangesAsync(); 
            }
            return book;
        }

        public async Task<Book> CreateBook(BookPost model)
        {
            var publisher = await _db.Publishers.FindAsync(model.PublisherId);
            var author = await _db.Authors.ToListAsync();

            if(publisher == null || model.Title == "string")
            {
                return null;
            }
            var book = new Book
            {
                Title = model.Title,
                PublisherId = model.PublisherId,
                Publisher = publisher
            };
            foreach(var authId in model.AuthorIds)
            {
                var thisauthor = await _db.Authors.FindAsync(authId);
                if(author == null) {
                    return null;
                }
                var bookauth = new BookAuthor
                {
                    Book = book,
                    Author = thisauthor,
                };

                _db.BookAuthors.Add(bookauth);
            }

            await _db.SaveChangesAsync();
            await _db.Entry(book).Collection(b => b.Bookauthors).LoadAsync();
            return book;   
        }

    }
}
