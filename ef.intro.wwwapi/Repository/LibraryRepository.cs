using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        public IEnumerable<Book> GetAllBooks()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    return db.Books.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Book GetBook(int id)
        {      
            using (var db = new LibraryContext())
            {
                Book result = db.Books.FirstOrDefault(b => b.Id == id);
                return result;
            }
        }

        public bool AddBook(Book book)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    db.Books.Add(book);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    db.Books.Update(book);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public bool DeleteBook(int id)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var bookToDelete = db.Books.FirstOrDefault(b => b.Id == id);
                    if (bookToDelete != null)
                    {
                        db.Books.Remove(bookToDelete);
                        int affectedRows = db.SaveChanges();
                        if (affectedRows > 0)
                        {
                            return true; 
                        }
                    }
                    return false; 
                }
            }
            catch (Exception ex)
            {
                return false; 
            }
        }
        
        public IEnumerable<Author> GetAllAuthors()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    return db.Authors.Include(a => a.Books).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Author GetAuthor(int id)
        {
            using (var db = new LibraryContext())
            {
                Author result = db.Authors.Include(a => a.Books).FirstOrDefault(a => a.Id == id);
                return result;
            }
        }

        public bool AddAuthor(Author author)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    db.Authors.Add(author);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateAuthor(Author author)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    db.Authors.Update(author);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteAuthor(int id)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var authorToDelete = db.Authors.FirstOrDefault(a => a.Id == id);
                    if (authorToDelete != null)
                    {
                        db.Authors.Remove(authorToDelete);
                        int affectedRows = db.SaveChanges();
                        if (affectedRows > 0)
                        {
                            return true; 
                        }
                    }
                    return false; 
                }
            }
            catch (Exception ex)
            {
                return false; 
            }
        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    return db.Publishers.Include(p => p.Books).ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public Publisher GetPublisher(int id)
        {
            using (var db = new LibraryContext())
            {
                Publisher result = db.Publishers.Include(p => p.Books).FirstOrDefault(p => p.Id == id);
                return result;
            }
        }

        public bool AddPublisher(Publisher publisher)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    db.Publishers.Add(publisher);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    db.Publishers.Update(publisher);
                    int affectedRows = db.SaveChanges();
                    return affectedRows > 0;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeletePublisher(int id)
        {
            try
            {
                using (var db = new LibraryContext())
                {
                    var publisherToDelete = db.Publishers.FirstOrDefault(p => p.Id == id);
                    if (publisherToDelete != null)
                    {
                        db.Publishers.Remove(publisherToDelete);
                        int affectedRows = db.SaveChanges();
                        if (affectedRows > 0)
                        {
                            return true; 
                        }
                    }
                    return false; 
                }
            }
            catch (Exception ex)
            {
                return false; 
            }
        }
    }
}
