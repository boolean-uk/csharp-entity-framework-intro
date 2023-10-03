using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        public bool AddAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                db.Authors.Add(author);
                db.SaveChanges();
                return true;
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

        public bool AddPublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Add(publisher);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                var authorToDelete = db.Authors.FirstOrDefault(a => a.Id == id);
                if (authorToDelete == null) return false;
                db.Authors.Remove(authorToDelete);
                db.SaveChanges();
                return true;
            }
        }
        public bool DeleteBook(int id)
        {
            using (var db = new LibraryContext())
            {
                var bookToDelete = db.Books.FirstOrDefault(b => b.Id == id);
                if (bookToDelete == null) return false;
                db.Books.Remove(bookToDelete);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeletePublisher(int id)
        {
            using (var db = new LibraryContext())
            {
                var publisherToDelete = db.Publishers.FirstOrDefault(p => p.Id == id);
                if (publisherToDelete == null) return false;
                db.Publishers.Remove(publisherToDelete);
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
        public IEnumerable<Book> GetAllBooks()
        {
            using (var db = new LibraryContext())
            {
                return db.Books.Include(b => b.Author).Include(b => b.Publisher).ToList();
            }
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var db = new LibraryContext())
            {
                return db.Publishers.ToList();
            }
        }

        public Author GetAuthor(int id)
        {
            Author result;
            using (var db = new LibraryContext())
            {
                return db.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == id);
            };
        }
        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                return db.Books.FirstOrDefault(b => b.Id == id);
            };
        }

        public Publisher GetPublisher(int id)
        {
            Publisher result;
            using (var db = new LibraryContext())
            {
                result = db.Publishers.FirstOrDefault(p => p.Id == id);
            };
            return result;
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                var authorToUpdate = db.Authors.FirstOrDefault(a => a.Id == author.Id);
                if (authorToUpdate == null) return false;
                authorToUpdate.FirstName = author.FirstName;
                authorToUpdate.LastName = author.LastName;
                authorToUpdate.Email = author.Email;
                // need to look into updating the books aswel or is this overkill if we also can update the book in its own method?
                db.SaveChanges();
                return true;
            };
        }
        public bool UpdateBook(Book book)
        {
            using (var db = new LibraryContext())
            {
                var bookToUpdate = db.Books.FirstOrDefault(b => b.Id == book.Id);
                if (bookToUpdate == null) return false;
                bookToUpdate.Title = book.Title;
                bookToUpdate.AuthorId = book.AuthorId;
                db.SaveChanges();
                return true;
            }
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                var publisherToUpdate = db.Publishers.FirstOrDefault(p => p.Id == publisher.Id);
                if (publisherToUpdate == null) return false;
                publisherToUpdate.Name = publisher.Name;
                db.SaveChanges();
                return true;
            };
        }
    }
}
