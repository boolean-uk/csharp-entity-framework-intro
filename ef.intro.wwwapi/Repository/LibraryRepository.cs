using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.AspNetCore.Components.Authorization;
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
            return null;
        }

        public Author GetAuthor(int id)
        {
            Author result;
            using (var db = new LibraryContext())
            {
                List<Author> authorList = new List<Author>();
                var author = new Author();
                authorList = db.Authors.Include(a => a.Books).ToList();
                foreach (var a in authorList)
                {
                    if (a.Id == id)
                    {
                        author = a;
                        return author;
                    }   
                }
                return null;
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
                return result;
            };
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
                return true;
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
                return true;
            };
            return false;

        }

        public IEnumerable<Publisher> GetAllPublishers()
        {
            using (var db = new LibraryContext())
            {
                return db.Publishers.ToList();
            }
            return null;
        }

        public bool AddPublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Add(publisher);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool UpdatePublisher(Publisher publisher)
        {
            using (var db = new LibraryContext())
            {
                db.Publishers.Find(publisher.Id).Name = publisher.Name;
                db.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeletePublisher(int id)
        {
            using (var db = new LibraryContext())
            {
                var publisher = db.Publishers.Find(id);
                if (publisher != null)
                {
                    db.Publishers.Remove(publisher);
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public Publisher GetPublisher(int id)
        {
            Publisher result;
            using (var db = new LibraryContext())
            {
                result = db.Publishers.Find(id);
                if (result != null)
                {
                    return result;
                }
                return null;
            }
        }
    }
}
