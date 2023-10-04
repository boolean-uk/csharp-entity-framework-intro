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

        public bool AddPublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Add(publisher);
                db.SaveChanges();
                return true;
            };
            return false;
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                var authorToRemove = db.Authors.Find(id);
                if (authorToRemove != null)
                {
                    db.Authors.Remove(authorToRemove);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                var bookToRemove = db.Books.Find(id);
                if (bookToRemove != null)
                {
                    db.Books.Remove(bookToRemove);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool DeletePublisher(int id)
        {
            using (var db = new LibraryContext())
            {
                var publisherToRemove = db.Publishers.Find(id);
                if (publisherToRemove != null)
                {
                    db.Publishers.Remove(publisherToRemove);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public IEnumerable<Author> GetAllAuthors()
        {
            using (var db = new LibraryContext())
            {
                return db.Authors.Include(a => a.Books).ThenInclude(b => b.Publisher).ToList();
            }
            return null;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.Include(p => p.Publisher).ToList();
            }
            return null;
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var db = new LibraryContext())
            {
                return db.Publishers.ToList();
            }
            return null;
        }

        public Author GetAuthor(int id)
        {
            Author result;
            using (var db = new LibraryContext())
            {
                return db.Authors.Find(id);
            }
            return result;
        }
        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                return db.Books.Find(id);
            }
            return result;
        }

        public Publisher GetPublisher(int id)
        {
            Publisher result;
            using (var db = new LibraryContext())
            {
                return db.Publishers.Find(id);
            }
            return result;
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                var existingAuthor = db.Authors.Find(author.Id);
                if (existingAuthor != null)
                {
                    
                    existingAuthor.FirstName = author.FirstName;
                    existingAuthor.LastName = author.LastName;
                    existingAuthor.Email = author.Email;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                var existingBook = db.Books.Find(book.Id);
                if (existingBook != null)
                {

                    existingBook.Title = book.Title;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
         }

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                var existingPublisher = db.Publishers.Find(publisher.Id);
                if (existingPublisher != null)
                {

                    existingPublisher.Name = publisher.Name;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}
