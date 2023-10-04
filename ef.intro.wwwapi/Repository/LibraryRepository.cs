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
                var result = db.Publishers.FirstOrDefault(p => p.Id == publisher.Id);
                if (result != null)
                    return false;

                db.Publishers.Add(publisher);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                var target = db.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == id);
                if (target != null)
                {
                    db.Remove(target);
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
                var target = db.Books.FirstOrDefault(b => b.Id == id);
                if (target != null)
                {
                    db.Remove(target);
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
                result = db.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == id);
            };
            return result;
        }
        public Book GetBook(int id)
        {
            Book result;
            using (var db = new LibraryContext())
            {
                result = db.Books.FirstOrDefault(b => b.Id == id);
            };
            return result;
        }

        public Publisher GetPublisher(int id)
        {
            Publisher result;
            using (var db = new LibraryContext())
            {
                result = db.Publishers.FirstOrDefault(p => p.Id == id);
            }
            return result;
        }

        public bool UpdateAuthor(Author author)
        {
            using (var db = new LibraryContext())
            {
                var target = db.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == author.Id);
                if (target != null)
                {
                    db.Authors.Attach(target);
                    target.FirstName = author.FirstName;
                    target.LastName = author.LastName;
                    target.Email = author.Email;
                    target.Books.AddRange(author.Books);
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
                var target = db.Books.FirstOrDefault(b => b.Id == book.Id);
                if (target != null)
                {
                    db.Books.Attach(target);
                    target.Title = book.Title;
                    target.AuthorId = book.AuthorId;
                    db.SaveChanges();
                    return true;
                }
            };
            return false;
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                var target = db.Publishers.FirstOrDefault(p => p.Id == publisher.Id);
                if (target != null)
                {
                    db.Publishers.Attach(target);
                    target.Name = publisher.Name;
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }
    }
}
