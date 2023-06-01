using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        public LibraryRepository() 
        { 
        
        }  
        public bool AddAuthor(Author author)
        {
            using(var db = new LibraryContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return true;
            }
            
        }
        public IEnumerable<Author> GetAllAuthors()
        {            
            using (var db = new LibraryContext())
            {
                return db.Authors.Include(a => a.Books).ToList();
            }
           
        }

        public bool AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Add(book);
                db.SaveChanges();
                return true;
            };
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                db.Remove(db.Authors.Find(id));
                db.SaveChanges();
                return true;
            };
        }

        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                db.Remove(db.Books.Find(id));
                db.SaveChanges();
                return true;
            };
            
        }

       

        public IEnumerable<Book> GetAllBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.ToList();
            }
            
        }

        public Author GetAuthor(int id)
        {
            Author result;
            using (var db = new LibraryContext())
            {
                return db.Authors.Find(id);        
            };
            
        }

        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                return db.Books.Find(id);             
            };
            
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                db.Authors.Find(author.Id).FirstName = author.FirstName;
                db.Authors.Find(author.Id).LastName = author.LastName;
                db.Authors.Find(author.Id).Email = author.Email;

                return true;
            };
           
        }

        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Find(book.Id).Title = book.Title;
                db.Books.Find(book.Id).AuthorId = book.AuthorId;
                return true;
            };
            
        }
    }
}
