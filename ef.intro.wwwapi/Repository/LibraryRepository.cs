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
                var author = db.Authors.Find(id);
                if (author != null) {
                    db.Remove(author);
                    db.SaveChanges();
                    return true;
                }
                return false;
            };
        }

        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                var book = db.Books.Find(id);
                if (book != null)
                {
                    db.Remove(book);
                    db.SaveChanges();
                    return true;
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
            
        }

        public Author GetAuthor(int id)
        {
           
            using (var db = new LibraryContext())
            {
                return db.Authors.Find(id);        
            };
            
        }

        public Book GetBook(int id)
        {
        
            using (var db = new LibraryContext())
            {
                return db.Books.Find(id);             
            };
            
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                if (db.Authors.Find(author.Id) != null) {
                    db.Authors.Find(author.Id).FirstName = author.FirstName;
                    db.Authors.Find(author.Id).LastName = author.LastName;
                    db.Authors.Find(author.Id).Email = author.Email;
                    db.Authors.Find(author.Id).Books = author.Books;
                    db.SaveChanges();

                    return true;
                }
                return false;
            };
           
        }

        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                if (db.Books.Find(book.Id) != null) {
                    db.Books.Find(book.Id).Title = book.Title;
                    db.Books.Find(book.Id).AuthorId = book.AuthorId;
                    db.SaveChanges(true);
                    return true;
                }
                return false;
            };
            
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var db = new LibraryContext())
            {
                return db.Publishers.ToList();
            }

        }

        public Publisher GetPublisher(int id)
        {
            using (var db = new LibraryContext())
            {
                return db.Publishers.Find(id);
            };
        }

        public bool AddPublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Add(publisher);
                db.SaveChanges ();
                return true;
            }
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                if(publisher != null)
                {
                    db.Publishers.Find(publisher.Id).Name = publisher.Name;
                    return true;
                }
                return false;
            }
        }

        public bool DeletePublisher(int id) 
        {
            using (var db = new LibraryContext())
            {
                var publisher = db.Publishers.Find(id);
                if (publisher != null)
                {
                    db.Remove(publisher);
                    db.SaveChanges();
                    return true;
                }
                return false;
            };

        }
    }
}
