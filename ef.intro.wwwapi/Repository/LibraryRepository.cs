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

        public bool AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Add(book);
                db.SaveChanges(); //did TODO
                return true;
            };
            return false;
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                var a = db.Authors.Find(id);
                if (a != null)
                {
                    db.Authors.Remove(a);
                    db.SaveChanges();
                    return true;        //did TODO
                }
                return false;
             };
        }

        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                var b = db.Books.Find(id);
                if (b != null)
                {
                    db.Books.Remove(b);
                    db.SaveChanges();
                    return true;        //did TODO
                }
                return false;
            };
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
                result = db.Authors.Find(id); // did TODO               
            };
            return result;
        }

        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                result = db.Books.Find(id); // did TODO               

            };
            return result;
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                db.Authors.Find(author.Id).FirstName = author.FirstName;
                db.Authors.Find(author.Id).LastName = author.LastName;
                db.Authors.Find(author.Id).Email = author.Email;
                db.Authors.Find(author.Id).Books = author.Books;
                db.SaveChanges();
                return true; // did TODO
            };
            return false;
        }

        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
               db.Books.Find(book.Id).Title = book.Title;
                db.Books.Find(book.Id).AuthorId = book.AuthorId;
                db.SaveChanges();
                return true; // did TODO
            };
            return false;
        }
    }
}
