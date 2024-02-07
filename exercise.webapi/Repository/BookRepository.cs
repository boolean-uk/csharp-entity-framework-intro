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
                .Include(ba => ba.Author)
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


    }
}
