using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        public bool AddAuthor(Author author)
        {
            using(var db = new LibraryContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return true;
            }
            return false;
        }
        public bool AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
               db.Books.Add(book);
                db.SaveChanges();
                return true;
            };
            return false;
        }
        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                var author = db.Authors.Find(id);
                if (author != null)
                {
                    db.Authors.Remove(author);
                    db.SaveChanges();
                    return true;
                }
               
            };
            return false;
        }
        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Find(id);
                if (book != null)
                {
                    db.Books.Remove(book);
                    db.SaveChanges();
                    return true;
                }
                return false;
            };
            return false;
        }
        public IEnumerable<Author> GetAllAuthors()
        {
            using (var db = new LibraryContext())
            {
                return db.Authors.Include(a => a.Books).ToList();
            }
            return null;
        }
        public IEnumerable<Book> GetAllBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.ToList();
            }
            return null;
        }
        public Author GetAuthor(int id)
        {
            Author result;
            using (var db = new LibraryContext())
            {
                 result = db.Authors.Find(id);
                if (result != null)
                {
                    
                    return result;
                }
            };
            return result;
        }
        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                result = db.Books.Find(id);
                if (result != null)
                {

                    return result;
                }
            };
            return result;
        }
        public bool UpdateAuthor(Author author)
        {
            
            using (var db = new LibraryContext())
            {
                var auth = db.Authors.Find(author.Id);
                
                if (auth != null)
                {
                    auth.Email = author.Email;
                    auth.FirstName = author.FirstName;
                    auth.LastName = author.LastName;
                    
                    //auth.Books = auth.Books.ToList();
                    db.SaveChanges();
                    
                     return true;
                }
            };
            return false;
        }
        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                var result = db.Books.Find(book.Id);
                if (result != null)
                {
                    result.Title = book.Title;
                    result.AuthorId = book.AuthorId;
                    //auth.Books = auth.Books.ToList();
                    db.SaveChanges();

                    return true;
                }
            };
            return false;
        }
    }
}
