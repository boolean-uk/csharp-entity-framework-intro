using ef.intro.wwwapi.Context;
using ef.intro.wwwapi.Models;
using Microsoft.EntityFrameworkCore;

namespace ef.intro.wwwapi.Repository
{
    public class LibraryRepository : ILibraryRepository
    {
        //added DI for not needing to do new LibraryContext
        private readonly LibraryContext _dbContext;
        public LibraryRepository(LibraryContext dbContext)
        {
            _dbContext = dbContext;
        }

        // re-aranged everything to follow crud in the correct order for author, book and publisher, used regions https://medium.com/@fdikmen/how-to-organize-your-code-with-regions-in-your-ide-391ebc8a41a6

        #region author
        public IEnumerable<Author> GetAllAuthors()
        {
            return _dbContext.Authors.ToList();
        }

        public Author GetAuthor(int id)
        {
            return _dbContext.Authors.FirstOrDefault(a => a.Id == id);
        }
        public bool AddAuthor(Author author)
        {
            try
            {
                _dbContext.Authors.Add(author);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateAuthor(Author author)
        {
            try
            {
                var authorToUpdate = _dbContext.Authors.Find(author.Id);
                if (authorToUpdate == null) return false;
                _dbContext.Entry(authorToUpdate).CurrentValues.SetValues(author);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteAuthor(int id)
        {
            try
            {
                var authorToDelete = _dbContext.Authors.Find(id);
                if (authorToDelete == null) return false;
                _dbContext.Authors.Remove(authorToDelete);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Book
        public IEnumerable<Book> GetAllBooks()
        {
            return _dbContext.Books.Include(b => b.Author).Include(b => b.Publisher).ToList();
        }

        public Book GetBook(int id)
        {
            return _dbContext.Books.Include(b => b.Author).Include(b => b.Publisher).FirstOrDefault(b => b.Id == id);
        }

        public bool AddBook(Book book)
        {
            try
            {
                _dbContext.Books.Add(book);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateBook(Book book)
        {
            try
            {
                var bookToUpdate = _dbContext.Books.Find(book.Id);
                if (bookToUpdate == null) return false;
                _dbContext.Entry(bookToUpdate).CurrentValues.SetValues(book);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteBook(int id)
        {
            try
            {
                var bookToDelete = _dbContext.Books.Find(id);
                if (bookToDelete == null) return false;
                _dbContext.Books.Remove(bookToDelete);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

        #region Publisher
        public IEnumerable<Publisher> GetAllPublishers()
        {
            return _dbContext.Publishers.ToList();
        }

        public Publisher GetPublisher(int id)
        {
            return _dbContext.Publishers.FirstOrDefault(p => p.Id == id);
        }

        public bool AddPublisher(Publisher publisher)
        {
            try
            {
                _dbContext.Publishers.Add(publisher);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool UpdatePublisher(Publisher publisher)
        {
            try
            {
                var publisherToUpdate = _dbContext.Publishers.Find(publisher.Id);
                if (publisherToUpdate == null) return false;
                _dbContext.Entry(publisherToUpdate).CurrentValues.SetValues(publisher);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeletePublisher(int id)
        {
            try
            {
                var publisherToDelete = _dbContext.Publishers.Find(id);
                if (publisherToDelete == null) return false;
                _dbContext.Publishers.Remove(publisherToDelete);
                _dbContext.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion
    }
}
