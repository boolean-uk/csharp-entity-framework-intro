using exercise.webapi.Data;
using exercise.webapi.Models;
using Microsoft.EntityFrameworkCore;

namespace exercise.webapi.Repository
{
    public class LibraryRepository: ILibraryRepository
    {
        DataContext _db;
        
        public LibraryRepository(DataContext db)
        {
            _db = db;
        }

        public async Task<IEnumerable<BookDto>> GetAllBooks()
        {
            var books = await _db.Books.Include(x => x.Author).Include(x => x.Publisher).ToListAsync();
            List<BookDto> result = new List<BookDto>();
            foreach (var book in books)
            {
                BookDto newBook = new BookDto(book);
                result.Add(newBook);
            }

            return result;

        }

        public async Task<BookDto> GetBook(int id)
        {
            if (await _db.Books.FirstOrDefaultAsync(x => x.Id == id) == null)
            {
                return null;
            }
            return new BookDto(await _db.Books.Include(x => x.Author).Include(x => x.Publisher).FirstOrDefaultAsync(x => x.Id == id));

        }
        public async Task<BookUpdateDto> UpdateBook(int id, int newId)
        {
            var book = await _db.Books.Include(x => x.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            book.AuthorId = newId;
            book.Author = await _db.Authors.FirstOrDefaultAsync(x => x.Id == newId);
            await _db.SaveChangesAsync();
            return new BookUpdateDto(book);

        }
        public async Task<BookDto> DeleteBook(int id)
        {
            var book = await _db.Books.Include(x => x.Author).Include(x => x.Publisher).FirstOrDefaultAsync(x => x.Id == id);
            _db.Books.Remove(book);
            await _db.SaveChangesAsync();
            var result = new BookDto(book);
            return result;

        }

        public async Task<Book> CreateBook(BookCreateDto book, int authorId, int publisherId)
        {
            var createdBook = new Book
            {
                Title = book.Title,
                AuthorId = authorId,
                PublisherId = publisherId
            };

            createdBook.Author = _db.Authors.Where(x => x.Id == authorId).FirstOrDefault();
            createdBook.Publisher = _db.Publishers.Where(x => x.Id == publisherId).FirstOrDefault();
            await _db.SaveChangesAsync();
            return createdBook;
        }

        public async Task<IEnumerable<AuthorDto>> GetAllAuthors()
        {
            var authors = await _db.Authors.ToListAsync();
            List<AuthorDto> result = new List<AuthorDto>();
            foreach (var author in authors)
            {
                AuthorDto newAuthor = new AuthorDto(author);
                var books = await _db.Books.Include(x => x.Publisher).Where(x => x.AuthorId == author.Id).ToListAsync();
                foreach (var book in books) 
                {
                    BookInAuthorDto newBook = new BookInAuthorDto(book);
                    newAuthor.Books.Add(newBook);
                }
                result.Add(newAuthor);
            }

            return result;
        }

        public async Task<AuthorDto> GetAuthor(int id)
        {
            if(await _db.Authors.FirstOrDefaultAsync(x => x.Id == id) == null)
            {
                return null;
            }
            var result = new AuthorDto(await _db.Authors.FirstOrDefaultAsync(x => x.Id == id));
            var books = await _db.Books.Include(x => x.Publisher).Where(x => x.AuthorId == id).ToListAsync();
            foreach (var book in books)
            {
                BookInAuthorDto newBook = new BookInAuthorDto(book);
                result.Books.Add(newBook);
            }
            return result;
        }

        public async Task<IEnumerable<PublisherDto>> GetAllPublishers()
        {
            var publishers = await _db.Publishers.ToListAsync();
            List<PublisherDto> result = new List<PublisherDto>();
            foreach (var publisher in publishers)
            {
                PublisherDto newPublisher = new PublisherDto(publisher);
                var books = await _db.Books.Where(x => x.PublisherId == publisher.Id).Include(x => x.Author).ToListAsync();
                foreach (var book in books)
                {
                    BookInPublisherDto newBook = new BookInPublisherDto(book);
                    newPublisher.Books.Add(newBook);
                }
                result.Add(newPublisher);
            }

            return result;
        }

        public async Task<PublisherDto> GetPublisher(int id)
        {
            if (await _db.Publishers.FirstOrDefaultAsync(x => x.Id == id) == null)
            {
                return null;
            }
            var result = new PublisherDto(await _db.Publishers.FirstOrDefaultAsync(x => x.Id == id));
            var books = await _db.Books.Where(x => x.PublisherId == id).Include(x=> x.Author).ToListAsync();
            foreach (var book in books)
            {
                BookInPublisherDto newBook = new BookInPublisherDto(book);
                result.Books.Add(newBook);
            }
            return result;
        }
    }
}
