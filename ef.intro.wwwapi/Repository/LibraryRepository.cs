using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        public IEnumerable<Book> GetAllBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.ToList();
            }
            // return null;
        }

        public Book GetBook(int id)
        {      
            Book result = null; 
            using (var db = new LibraryContext())
            {
                result = db.Books.FirstOrDefault(b => b.Id == id);
            }
            return result; 
        }

        public bool AddBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Add(book);
                int affectedRows = db.SaveChanges();
                if (affectedRows > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                db.Books.Update(book);
                int affectedRows = db.SaveChanges();
                if (affectedRows > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(b => b.Id == id);
                if (bookToDelete != null)
                {
                    db.Books.Remove(bookToDelete);
                    db.SaveChanges();
                    return true;
                }
            };
            return false;
        }
        
        public IEnumerable<Author> GetAllAuthors()
        {
            using (var db = new LibraryContext())
            {
                return db.Authors.Include(a => a.Books).ToList();
            }
            // return null;
        }

        public Author GetAuthor(int id)
        {
            Author result = null;
            using (var db = new LibraryContext())
            {
                result = db.Authors.FirstOrDefault(a => a.Id == id);
            }
            return result;
        }

        public bool AddAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                db.Authors.Add(author);
                int affectedRows = db.SaveChanges();
                if (affectedRows > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                db.Authors.Update(author);
                int affectedRows = db.SaveChanges();
                if (affectedRows > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                var authorToDelete = db.Authors.FirstOrDefault(a => a.Id == id);
                if (authorToDelete != null)
                {
                    db.Authors.Remove(authorToDelete);
                    db.SaveChanges();
                    return true;
                }
            };
            return false;
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var db = new LibraryContext())
            {
                return db.Publishers.Include(p => p.Books).ToList();
            }
            // return null;
        }

        public Publisher GetPublisher(int id)
        {
            Publisher result = null;
            using (var db = new LibraryContext())
            {
                result = db.Publishers.FirstOrDefault(p => p.Id == id);
            }
            return result;
        }

        public bool AddPublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Add(publisher);
                int affectedRows = db.SaveChanges();
                if (affectedRows > 0)
                {
                    return true;
                }
                return false;
            }
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Update(publisher);
                int affectedRows = db.SaveChanges();
                if (affectedRows > 0)
                {
                    return true; 
                }
                return false; 
            }
        }

        public bool DeletePublisher(int id)
        {
            using (var db = new LibraryContext())
            {
                var publisherToDelete = db.Publishers.FirstOrDefault(p => p.Id == id);
                if (publisherToDelete != null)
                {
                    db.Publishers.Remove(publisherToDelete);
                    db.SaveChanges();
                    return true;
                }
            };
            return false;
        }
    }
}